using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.BD
{
    class Connection
    {
        SqlConnection connection = null;
        public Connection()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public SqlConnection OpenC()
        {
            SqlConnection connex = new SqlConnection("Data Source = DESKTOP-6CK8G9P\\SQLEXPRESS;Initial Catalog = veterinaria; Integrated Security=True;");
            connex.Open();
            return connex;
        }
        public void CloseC()
        {
            if (connection != null) connection.Close();
        }
    }
}
