﻿using DAL.EF;
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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}