using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dealer.Properties;

namespace Dealer
{
    class ConnectionDB
    {
        public static SqlConnection conectar()
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection(Dealer.Properties.Settings.Default.DealerDBConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con = null;
            }
            return con;
        }
    }
}
