using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DepartmentRepo : IRepo<Department, int>
    {
        SolidPractiseEntities db;
        public DepartmentRepo(SolidPractiseEntities db)
        {
            this.db = db;
        }
        public bool Create(Department obj)
        {
            db.Departments.Add(obj);
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            var info = db.Departments.ToList();
            return info;
        }

        public Department Get(int id)
        {
            var info = db.Departments.Find(id);
            return info;
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
