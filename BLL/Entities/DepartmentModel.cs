using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class DepartmentModel
    {
        public DepartmentModel()
        {
            this.Courses = new HashSet<CoursModel>();
            this.Students = new HashSet<StudentModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CoursModel> Courses { get; set; }
        public virtual ICollection<StudentModel> Students { get; set; }
    }
}
