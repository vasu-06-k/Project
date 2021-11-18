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
        SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
        public int ValidateUser(Loginadm P)
        {
            //SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
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
    }

    public class EmployeeDetailsDAL
    {
        List<EmployeeDetails> emp = new List<EmployeeDetails>();
        SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
        public void add(EmployeeDetails e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from EmployeeDetails", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[1] = e.EmployeeName;
            r[2] = e.DateOfBirth;
            r[3] = e.Gender;
            r[4] = e.EmpStatus;
            r[5] = e.Designation;
            r[6] = e.DeptNo;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.PhoneNo;
            r[10] = e.ManagerId;
            r[11] = e.WorkLocation;
            r[12] = e.JoiningDate;
            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public void update(int i, EmployeeDetails e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from EmployeeDetails", cn);
            d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].Rows.Find(i);
            r[1] = e.EmployeeName;
            r[2] = e.DateOfBirth;
            r[3] = e.Gender;
            r[4] = e.EmpStatus;
            r[5] = e.Designation;
            r[6] = e.DeptNo;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.PhoneNo;
            r[10] = e.ManagerId;
            r[11] = e.WorkLocation;
            r[12] = e.JoiningDate;
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public DataTable showDetails(int p)
        {
            string s = "select * from EmployeeDetails where EmployeeId=" + p;
            SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "EmployeeDetails");
            DataTable t = ds.Tables["EmployeeDetails"];
            return t;
        }

        public List<EmployeeDetails> showAll()
        {
            string s = "select * from EmployeeDetails";
            SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "EmployeeDetails");
            DataTable t = ds.Tables["EmployeeDetails"];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                EmployeeDetails e = new EmployeeDetails();
                e.EmployeeID = Convert.ToInt32(t.Rows[i][0]);
                e.EmployeeName = Convert.ToString(t.Rows[i][1]);
                ; e.DateOfBirth = Convert.ToDateTime(t.Rows[i][2]);
                e.Gender = Convert.ToString(t.Rows[i][3]);
                e.EmpStatus = Convert.ToString(t.Rows[i][4]);
                e.Designation = Convert.ToString(t.Rows[i][5]);
                e.DeptNo = Convert.ToInt32(t.Rows[i][6]);
                e.Address = Convert.ToString(t.Rows[i][7]);
                e.Nationality = Convert.ToString(t.Rows[i][8]);
                e.PhoneNo = Convert.ToInt64(t.Rows[i][9]);
                e.ManagerId = Convert.ToInt32(t.Rows[i][10]);
                e.WorkLocation = Convert.ToString(t.Rows[i][11]);
                e.JoiningDate = Convert.ToDateTime(t.Rows[i][12]);
                emp.Add(e);
            }
            return emp;
        }
    }
}
