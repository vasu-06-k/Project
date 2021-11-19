using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBAL1
{
    public class ResumeBAL
    {
		public int ResumeId { get; set; }
		public string FullName { get; set; }
		public DateTime DOB { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public double PhoneNo { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public string Nationality { get; set; }
		public string Experience { get; set; }
		public string Interest { get; set; }
		public string Specialization { get; set; }
		public int TenthPercent { get; set; }
		public int TwelfthPercent { get; set; }
		public string College { get; set; }
		public string GraduationCourse { get; set; }
		public string Branch { get; set; }
		public int YearOfGraduation { get; set; }
		public int TotalCGPA { get; set; }

        public string Filepath { get; set; }
    }
}
