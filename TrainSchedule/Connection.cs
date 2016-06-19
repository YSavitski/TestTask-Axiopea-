using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSchedule
{
    public static class Connection
    {
        //public static string str_connection = @"Data Source = ESAVITSKY; Initial Catalog = TrainDB; Integrated Security = True; Pooling = true";

        public static string ConnectionStr()
        {
            string str_connection = "";
            try
            {
                using (StreamReader reader = new StreamReader("ConnectionConfig.txt"))
                {
                    str_connection = string.Format(@"{0}", reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return str_connection;
        }
    }
}
