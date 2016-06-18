using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSchedule
{
    
    public partial class AddScheduleForm : Form
    {
        private SqlDataAdapter adapter;
        DataTable tblListTrainByStantion = new DataTable("tblListTrainByStantion");
        private DataTable tblSchedule = new DataTable("tblSchedule");
        
        
        public AddScheduleForm()
        {
            InitializeComponent();
            this.CenterToParent();
            gbAddSchedule.Visible = false;
        }


        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            tblSchedule.Columns.Add("TrainN", typeof(string));
            tblSchedule.Columns.Add("StantionName", typeof(string));
            tblSchedule.Columns.Add("DateIn", typeof(DateTime));
            tblSchedule.Columns.Add("TimeArrive", typeof(TimeSpan));
            tblSchedule.Columns.Add("TimeLeave", typeof(TimeSpan));
            UniqueConstraint uniqueSchedule = new UniqueConstraint(new DataColumn[]
                    {tblSchedule.Columns["TrainN"], tblSchedule.Columns["StantionName"], tblSchedule.Columns["DateIn"],
                        tblSchedule.Columns["TimeArrive"], tblSchedule.Columns["TimeLeave"]});
            tblSchedule.Constraints.Add(uniqueSchedule);
        }

        private void btnSearchByStantion_Click(object sender, EventArgs e)
        {
            ShowTrainListByStantion(Connection.str_connection);
        }

        private void btnAddScheduleForCurrRow_Click(object sender, EventArgs e)
        {
            try
            {
                var currRow = (dgvTrainsInStantion.CurrentRow.DataBoundItem as DataRowView).Row;
                tbTrainNSchedule.Text = currRow["TrainN"].ToString();
                tbStantionSchedule.Text = currRow["StantionName"].ToString();
                tbTrainNSchedule.ReadOnly = true;
                tbStantionSchedule.ReadOnly = true;
                gbAddSchedule.Visible = true;
                dgvSchedule.ReadOnly = true;
                ShowSchedule(currRow["TrainN"].ToString(), currRow["StantionName"].ToString());
                tbSeachByStantion.ReadOnly = true;
                btnSearchByStantion.Enabled = false; 
                btnAddScheduleForCurrRow.Enabled = false;
                dtpActionFrom.Format = DateTimePickerFormat.Short;
                dtpActionTo.Format = DateTimePickerFormat.Short;
                dtpTimeArrive.Format = DateTimePickerFormat.Time;
                dtpTimeLeave.Format = DateTimePickerFormat.Time;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}:\n{1}", DateTime.Now, ex.Message), ex.GetType().ToString(),
                    MessageBoxButtons.OK);
            }
        }


        private void ShowTrainListByStantion(string str_connection)
        {
            tblListTrainByStantion.Clear();
            using (SqlConnection connection = new SqlConnection(str_connection))
            {
                connection.Open();
                SqlCommand cmd_ShowListTrain = new SqlCommand(string.Format("SELECT s.StantionName, tats.TrainN, t.TrainItenerary FROM TrainsAtTheStantions AS tats " +
                                                                            "INNER JOIN Train AS t ON t.TrainN = tats.TrainN " +
                                                                            "INNER JOIN Stantion AS s ON s.ID_Stantion = tats.ID_Stantion " +
                                                                            "WHERE s.StantionName LIKE '%{0}%'", tbSeachByStantion.Text), connection);
                using (adapter = new SqlDataAdapter(cmd_ShowListTrain))
                {
                    try
                    {
                        adapter.Fill(tblListTrainByStantion);
                        dgvTrainsInStantion.DataSource = tblListTrainByStantion;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }

        private void ShowSchedule(string TrainN, string StantionName)
        {
            using (SqlConnection connection = new SqlConnection(Connection.str_connection))
            {
                connection.Open();
                SqlCommand cmd_ShowCurrentSchedule = new SqlCommand(string.Format("SELECT s.TrainN, s2.StantionName, s.DateIn, s.TimeArrive, s.TimeLeave " +
                                                                                  "FROM Schedule AS s INNER JOIN Stantion AS s2 " +
                                                                                        "ON s2.ID_Stantion = s.ID_Stantion " +
                                                                                        "WHERE s.TrainN LIKE '%{0}%' AND s2.StantionName LIKE '%{1}%'",
                                                                                        TrainN, StantionName), connection);
                using (adapter = new SqlDataAdapter(cmd_ShowCurrentSchedule))
                {
                    try
                    {
                        adapter.Fill(tblSchedule);
                        dgvSchedule.DataSource = tblSchedule;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }

        private void btnCancelRecordSch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKRecordSch_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void btnAddRecordSch_Click(object sender, EventArgs e)
        {
            AddRecordInSchedule(tbTrainNSchedule.Text, tbStantionSchedule.Text,
                dtpActionFrom.Value.Date, dtpActionTo.Value.Date, dtpTimeArrive.Value.TimeOfDay, dtpTimeLeave.Value.TimeOfDay);
        }

        private void AddRecordInSchedule(string trainN, 
                                            string stantionName, DateTime actionFrom, DateTime actionTo, 
                                            TimeSpan timeArrive, TimeSpan timeLeave)
        {
            if (rbOtherDate.Checked || rbDaily.Checked || rbEvenUnEven.Checked || rbWeekly.Checked)
            {
                DataRow newRow;

                while (actionFrom.CompareTo(actionTo) <= 0)
                {
                    newRow = this.tblSchedule.NewRow();
                    newRow["TrainN"] = trainN;
                    newRow["StantionName"] = stantionName;
                    newRow["DateIn"] = actionFrom.Date;
                    newRow["TimeArrive"] = timeArrive;
                    newRow["TimeLeave"] = timeLeave;
                    MessageBox.Show(string.Format("TrainN: {0}\nStantionName: {1}\nDateIn: {2}\nTimeArrive: {3}\nTimeLeave: {4}",
                        trainN, stantionName, actionFrom.Date, timeArrive, timeLeave));
                    try
                    {
                        if (rbDaily.Checked)
                        {
                            this.tblSchedule.Rows.Add(newRow);
                            actionFrom = actionFrom.AddHours(24);
                        }
                        //else if (rbWeekly.Checked)
                        //{
                        //    actionFrom = actionFrom.AddDays(7);
                        //}
                        else if (rbEvenUnEven.Checked)
                        {
                            this.tblSchedule.Rows.Add(newRow);
                            actionFrom = actionFrom.AddHours(48);
                        }
                        else if (rbOtherDate.Checked)
                        {
                            if (actionFrom.CompareTo(actionTo) == 0)
                            {
                                this.tblSchedule.Rows.Add(newRow);
                                break;
                            }
                            else
                            {
                                MessageBox.Show(string.Format("{0}\nDates ActionFrom and ActionTo must be equal."),
                                    "Incorrec select dates!");
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        if (rbDaily.Checked)
                        {
                            actionFrom = actionFrom.AddHours(24);
                        }
                        //else if (rbWeekly.Checked)
                        //{
                        //    actionFrom = actionFrom.AddDays(7);
                        //}
                        else if (rbEvenUnEven.Checked)
                        {
                            actionFrom = actionFrom.AddHours(48);
                        }

                        else if (rbOtherDate.Checked)
                        {
                            break;
                        }
                        continue;
                    }
                    tblSchedule.AcceptChanges();
                    dgvSchedule.DataSource = tblSchedule;
                }
            }

            else
            {
                MessageBox.Show("You need select period!!!");
            }
        }

        
    }
}
