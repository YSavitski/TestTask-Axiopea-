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
    public partial class AddTrainForm : Form
    {
        DataTable tblListTrain = new DataTable("tblListTrain");
        private SqlDataAdapter adapter;
        public AddTrainForm()
        {
            InitializeComponent();
            this.CenterToParent();
            

        }

        public void ShowTrainList(string str_connection)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
            {
                connection.Open();
                SqlCommand cmd_ShowListTrain = new SqlCommand("SELECT *FROM Train AS t", connection);
                using (adapter = new SqlDataAdapter(cmd_ShowListTrain))
                {
                    try
                    {
                        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        adapter.FillSchema(tblListTrain, SchemaType.Mapped);
                        adapter.Fill(tblListTrain);
                        dgvListTrains.DataSource = tblListTrain;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }




        private void AddTrainForm_Load(object sender, EventArgs e)
        {
            ShowTrainList(Connection.ConnectionStr());

        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
            {
                connection.Open();
                SqlCommand cmd_AddTrain = connection.CreateCommand();
                SqlTransaction tran_AddTrain;
                tran_AddTrain = connection.BeginTransaction("tran_AddTrain");
                cmd_AddTrain.Connection = connection;
                cmd_AddTrain.Transaction = tran_AddTrain;
                if (tbTrainN.Text.Length > 0 && tbTrainItinerary.Text.Length > 0)
                {
                    try
                    {
                        cmd_AddTrain.CommandText = string.Format("INSERT INTO Train (TrainN, TrainItenerary) " +
                                                            "VALUES ('{0}', '{1}')", tbTrainN.Text, tbTrainItinerary.Text);
                        cmd_AddTrain.ExecuteNonQuery();
                        tran_AddTrain.Commit();
                        MessageBox.Show("Both records are written to database", "Sucsess", MessageBoxButtons.OK);
                        ShowTrainList(Connection.ConnectionStr());
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(
                            string.Format("Commit Exeption Type: {0}.\n Message: {1}", ex1.GetType(), ex1.Message),
                            "Error", MessageBoxButtons.OK);
                        try
                        {
                            tran_AddTrain.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(
                            string.Format("Rollback Exeption Type: {0}.\n Message: {1}", ex1.GetType(), ex1.Message),
                            "Error", MessageBoxButtons.OK);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Incorrect input data in textboxes", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancelTrain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
