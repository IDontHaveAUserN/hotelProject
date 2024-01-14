using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    internal class Sql
    { 
        //SqlCommand cmd = new SqlCommand();

        private static string myConnection = "Data Source=DESKTOP-G3LM9P9\\SQLEXPRESS; Initial Catalog = HotelReservationSystem; Integrated Security = True; Encrypt=False";

        SqlConnection sql = new SqlConnection(myConnection);

        public SqlConnection abrirConexao()
        {
            if(sql.State == System.Data.ConnectionState.Closed)
            {
                sql.Open();
                //MessageBox.Show("Successful");
            }
            return sql;
        }

        public SqlConnection fecharConexao()
        {
            if (sql.State == System.Data.ConnectionState.Open)
            {
                sql.Close();
            }
            return sql;
        }
    }
}
