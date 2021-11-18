using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRBAL1;

namespace HRDAL
{
     public class ProjectDAL
    {
        List<Project> projects = new List<Project>();
        SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
        public void add(Project e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from Project", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[0] = e.ProjectId;
            r[1] = e.ProjectName;
            r[2] = e.ClientName;
            r[3] = e.NoOfDays;
           
            
            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public List<Project> showAll()
        {
            string s = "select * from Project";
            SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "EmployeeDetails");
            DataTable t = ds.Tables["EmployeeDetails"];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                Project e = new Project();
                e.ProjectId = Convert.ToInt32(t.Rows[i][0]);
                e.ProjectName = Convert.ToString(t.Rows[i][1]);
                 e.ClientName = Convert.ToString(t.Rows[i][2]);
                e.NoOfDays = Convert.ToInt32(t.Rows[i][3]);                    
                projects.Add(e);
            }
            return projects;
        }
    }
}
