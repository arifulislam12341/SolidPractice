using BLL.Entities;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentModel> Get()
        {
            var data = DataAccessFactory.StudentDataAccess().Get();
            var student = new List<StudentModel>();

            foreach(var item in data)
            {
                student.Add(new StudentModel()
                {
                    Address = item.Address,
                    Name = item.Name,
                    Cgpa = item.Cgpa,
                    Dob =item.Dob,
                    Deptid=item.Deptid, 
                });
            }
            return student;
        }
        public static StudentModel Get(int id)
        {
            var data = DataAccessFactory.StudentDataAccess().Get(id);
            var student = new StudentModel() {
                Address = data.Address,
            Name = data.Name,
            Cgpa = data.Cgpa,
            Dob = data.Dob,
            Deptid = data.Deptid
        };
            return student;

        }

        public static bool Create(StudentModel obj)
        {
            var student = new Student();
                student.Name = obj.Name;
            student.Address = obj.Address;
            student.Cgpa = obj.Cgpa;
            student.Deptid = obj.Deptid;
            student.Dob = obj.Dob;


            return DataAccessFactory.StudentDataAccess().Create(student);
        }

    }
}
