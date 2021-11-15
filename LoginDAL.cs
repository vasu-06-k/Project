using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRBAL1;

namespace HRDAL
{
    public class LoginDAL
    {
        public int ValidateUser(Loginadmin P)
        {
            SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
            cn.Open();
            string s = "SELECT [dbo].[Admin_Validation](@adminId, @adminPassword)";
            SqlCommand cmd = new SqlCommand(s, cn);           
            cmd.Parameters.AddWithValue("@adminId",P.username);
            cmd.Parameters.AddWithValue("@adminPassword", P.password);
            var result = cmd.ExecuteScalar();
            cn.Close();
            cn.Dispose();
            return (int)result;
        }
        public void insert()
        {
           

        }
    }
}
