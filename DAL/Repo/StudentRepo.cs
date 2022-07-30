using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo : IRepo<Student, int>
    {
        SolidPractiseEntities db;

        public StudentRepo(SolidPractiseEntities db)
        {
            this.db = db;
        }

        public bool Create(Student obj)
        {
            db.Students.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
          var studentid=Get(id)  ;
            db.Students.Remove(studentid);
            return true;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Get(int id)
        {
            var studentid=Get(id);
            return db.Students.Find(studentid);
        }

        public bool Update(Student obj)
        {
            var students= new Student();
            students.Name = obj.Name;
            students.Address = obj.Address;
            students.Cgpa = obj.Cgpa;
             db.SaveChanges();
            return true;
        }
    }
}
