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
    public class ResumeDAL
    {
        List<ResumeBAL> resume = new List<ResumeBAL>();
        SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
        public void add(ResumeBAL e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from ResumeTracker", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[1] = e.FullName;
            r[2] = e.DOB;
            r[3] = e.Age;
            r[4] = e.Email;
            r[5] = e.PhoneNo;
            r[6] = e.Gender;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.Experience;
            r[10] = e.Interest;
            r[11] = e.Specialization;
            r[12] = e.TenthPercent;
            r[13] = e.TwelfthPercent;
            r[14] = e.College;
            r[15] = e.GraduationCourse;
            r[16] = e.Branch;
            r[17] = e.YearOfGraduation;
            r[18] = e.TotalCGPA;
            r[19] = e.Filepath;
            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }

        public List<ResumeBAL> showAll()
        {
            string s = "select * from ResumeTracker";
            //SqlConnection cn = new SqlConnection("Data Source=desktop-hcdpgum\\sqlexpress;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "ResumeTracker");
            DataTable t = ds.Tables["ResumeTracker"];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                ResumeBAL e = new ResumeBAL();
                e.ResumeId = Convert.ToInt32(t.Rows[i][0]);
                e.FullName = Convert.ToString(t.Rows[i][1]);
                e.DOB = Convert.ToDateTime(t.Rows[i][2]);
                e.Age = Convert.ToInt32(t.Rows[i][3]);
                e.Email = Convert.ToString(t.Rows[i][4]);
                e.PhoneNo = Convert.ToInt64(t.Rows[i][5]);
                e.Gender = Convert.ToString(t.Rows[i][6]);
                e.Address = Convert.ToString(t.Rows[i][7]);
                e.Nationality = Convert.ToString(t.Rows[i][8]);
                e.Experience = Convert.ToString(t.Rows[i][9]);
                e.Interest = Convert.ToString(t.Rows[i][10]);
                e.Specialization = Convert.ToString(t.Rows[i][11]);
                e.TenthPercent = Convert.ToInt32(t.Rows[i][12]);
                e.TwelfthPercent = Convert.ToInt32(t.Rows[i][13]);
                e.College = Convert.ToString(t.Rows[i][14]);
                e.GraduationCourse = Convert.ToString(t.Rows[i][15]);
                e.Branch = Convert.ToString(t.Rows[i][16]);
                e.YearOfGraduation = Convert.ToInt32(t.Rows[i][17]);
                e.TotalCGPA = Convert.ToInt32(t.Rows[i][18]);
                e.Filepath = Convert.ToString(t.Rows[i][19]);
                resume.Add(e);
            }
            return resume;
        }
        public void send(ResumeBAL e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from EmployeeDetails", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[1] = e.FullName;
            r[2] = e.DOB;                
            r[3] = e.Gender;
            r[7] = e.Address;
            r[8] = e.Nationality;
            r[9] = e.PhoneNo;         
            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }

        public void deleteresume(int p)
        {
            cn.Open();
            //int p = e.ResumeId;
            string s = "DELETE FROM ResumeTracker WHERE ResumeId=" + p;
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }

       public void sendfilepath(string path)
        {
            string f = path;
            cn.Open();
            string s = "Insert into ResumeTracker (Filepath) values ('" + f +"')";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }

    }
}
