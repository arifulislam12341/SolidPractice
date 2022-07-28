using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public Nullable<double> Cgpa { get; set; }
        public Nullable<int> Deptid { get; set; }

        public virtual DepartmentModel Department { get; set; }
    }
}
