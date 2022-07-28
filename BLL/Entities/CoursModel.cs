using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CoursModel
    {
        public CoursModel()
        {
            this.StudentCourses = new HashSet<StudentCours>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Deptid { get; set; }

        public virtual DepartmentModel Department { get; set; }
        public virtual ICollection<StudentCours> StudentCourses { get; set; }
    }
}
