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
    public partial class MainForm : Form
    {
        DataTable tblDefaultData = new DataTable("tblDafaultData");
        DataTable tblSearchData = new DataTable("tblSearchData");
        SqlDataAdapter adapter;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddScheduleForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.str_connection))
            {
                connection.Open();

                SqlCommand cmd_defaultSelect = new SqlCommand(string.Format("SELECT s.TrainN, t.TrainItenerary, s2.StantionName, s.DateIn, s.TimeArrive, s.TimeLeave " +
                                                                            "FROM Schedule AS s INNER JOIN Stantion AS s2 ON s2.ID_Stantion = s.ID_Stantion " +
                                                                            "INNER JOIN Train AS t ON s.TrainN = t.TrainN " +
                                                                            "WHERE s2.ID_Stantion IN " +
                                                                                "(SELECT s3.ID_Stantion FROM Stantion AS s3 " +
                                                                                "WHERE s3.StantionName LIKE '%{0}%') " +
                                                                            "AND s.DateIn = CAST('{1}' AS DATE)",
                                                                    tbStantionNameFind.Text, DateTime.Now.Date), connection);
                using (adapter = new SqlDataAdapter(cmd_defaultSelect))
                {
                    try
                    {
                        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        adapter.FillSchema(tblDefaultData, SchemaType.Mapped);
                        adapter.Fill(tblDefaultData);
                        dgvListSchedule.DataSource = tblDefaultData;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvListSchedule.ClearSelection();
            tblSearchData.Clear();
            using (SqlConnection connection = new SqlConnection(Connection.str_connection))
            {
                connection.Open();

                SqlCommand cmd_defaultSelect = new SqlCommand(string.Format("SELECT s.TrainN, t.TrainItenerary, s2.StantionName, s.DateIn, s.TimeArrive, s.TimeLeave " +
                                                                            "FROM Schedule AS s INNER JOIN Stantion AS s2 ON s2.ID_Stantion = s.ID_Stantion " +
                                                                            "INNER JOIN Train AS t ON s.TrainN = t.TrainN " +
                                                                            "WHERE s2.ID_Stantion IN " +
                                                                                "(SELECT s3.ID_Stantion FROM Stantion AS s3 " +
                                                                                "WHERE s3.StantionName LIKE '%{0}%') " +
                                                                            "AND s.DateIn = CAST('{1}' AS DATE)",
                                                                    tbStantionNameFind.Text, dtpCurrentDate.Value.ToShortDateString()), connection);
                using (adapter = new SqlDataAdapter(cmd_defaultSelect))
                {
                    try
                    {
                        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        adapter.FillSchema(tblSearchData, SchemaType.Mapped);
                        adapter.Fill(tblSearchData);
                        dgvListSchedule.DataSource = tblSearchData;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }

        private void dtpCurrentDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddTrainForm().ShowDialog();
        }
    }
}
