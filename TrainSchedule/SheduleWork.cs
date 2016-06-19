using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSchedule
{
    static class SheduleWork
    {
        public static void InsertRecords(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    InsertRecords(row);
                }
            }
        }

        private static void InsertRecords(DataRow row)
        {
            using (SqlConnection connection = new SqlConnection(Connection.str_connection))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    throw;
                }

                using (SqlCommand cmd_InsertRecord = new SqlCommand("spInsertInSchedule", connection))
                {
                    cmd_InsertRecord.CommandType = CommandType.StoredProcedure;

                    cmd_InsertRecord.Parameters.AddWithValue("TrainN", row[0]);
                    cmd_InsertRecord.Parameters.AddWithValue("StantionName", row[1]);
                    cmd_InsertRecord.Parameters.AddWithValue("DateIn", row[2]);
                    cmd_InsertRecord.Parameters.AddWithValue("TimeArrive", row[3]);
                    cmd_InsertRecord.Parameters.AddWithValue("TimeLeave", row[4]);

                    try
                    {
                        cmd_InsertRecord.ExecuteNonQuery();
                        MessageBox.Show("Success Inserting!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    finally
                    {
                        row.AcceptChanges();
                    }
                }
            }
        }
    }
}
