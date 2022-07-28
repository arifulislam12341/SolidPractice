using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static SolidPractiseEntities db =new SolidPractiseEntities();

        public static IRepo<Department,int> DepartmentDataAccess()
        {
            return new DepartmentRepo(db);
        }

        public static IRepo<Student, int> StudentDataAccess()
        {
            return new StudentRepo(db);
        }
        public static IRepo<Course, int> CourseDataAccess()
        {
            return new Course(db);
        }
    }
}
