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
        private DataTable tblScheduleDates = new DataTable("tblScheduleDates");
        
        public AddScheduleForm()
        {
            InitializeComponent();
            this.CenterToParent();
            gbAddSchedule.Visible = false;
        }

        private void ShowTrainListByStantion(string str_connection)
        {
            tblListTrainByStantion.Clear();
            using (SqlConnection connection = new SqlConnection(str_connection))
            {
                connection.Open();
                SqlCommand cmd_ShowListTrain = new SqlCommand(string.Format("SELECT t.TrainN, t.TrainItenerary, s2.StantionName FROM Train AS t " +
                                                                            "INNER JOIN Schedule AS s ON s.TrainN = t.TrainN " +
                                                                            "INNER JOIN Stantion AS s2 ON s2.ID_Stantion = s.ID_Stantion " +
                                                                            "WHERE s2.StantionName LIKE '%{0}%'", tbSeachByStantion.Text), connection);
                using (adapter = new SqlDataAdapter(cmd_ShowListTrain))
                {
                    try
                    {
                        adapter.Fill(tblListTrainByStantion);
                        dgvTrainsInStantion.DataSource = tblListTrainByStantion;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), "Connection error", MessageBoxButtons.RetryCancel);
                    }
                }
            }
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
                tbSeachByStantion.ReadOnly = true;
                btnSearchByStantion.Enabled = false; 
                btnAddScheduleForCurrRow.Enabled = false;
                dtpActionFrom.Format = DateTimePickerFormat.Short;
                dtpActionTo.Format = DateTimePickerFormat.Short;
                dtpTimeArrive.Format = DateTimePickerFormat.Time;
                dtpTimeLeave.Format = DateTimePickerFormat.Time;


                //MessageBox.Show(string.Format("{0}\n{1}\n{2}\n{3}",
                //    dtpActionFrom.Value.Date, dtpActionTo.Value.ToShortDateString(), dtpTimeArrive.Value.Date,
                //    dtpTimeLeave.Value.TimeOfDay));

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}:\n{1}", DateTime.Now, ex.Message), ex.GetType().ToString(),
                    MessageBoxButtons.OK);
            }
        }
    }
}
