
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace IMS
{
    class sql
    {
        public DataTable queryexecution(string query)
        {
            string strstring = "Data Source=.;Database=IMS;Integrated Security=True";
            SqlConnection sqcon = new SqlConnection(strstring);
            sqcon.Open();
            SqlCommand sqccmd = new SqlCommand();
            sqccmd.CommandText = query;
            sqccmd.CommandTimeout = 600;
            sqccmd.Connection = sqcon;

            SqlDataAdapter sqdatadap = new SqlDataAdapter(sqccmd);

            DataTable dtresult = new DataTable();

            sqdatadap.Fill(dtresult);

            sqcon.Close();
            return dtresult;
        }

    }
}
