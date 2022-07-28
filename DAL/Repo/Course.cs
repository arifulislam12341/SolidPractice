using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{

    public class Course : IRepo<Course, int>
    {
        SolidPractiseEntities db;

        public Course(SolidPractiseEntities db)
        {
            this.db = db;   
        }
        public bool Create(Course obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
