using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class DepartmentStudentModel:DepartmentModel
    {
        public List<StudentModel> Student { get; set; }
        public DepartmentStudentModel()
        {
            Students = new List<StudentModel>();
        }
    }
}
