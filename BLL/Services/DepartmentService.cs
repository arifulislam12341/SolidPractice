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
    public class DepartmentService
    {
        public static List<DepartmentModel> Get()
        {

            var data = DataAccessFactory.DepartmentDataAccess().Get();

            var depts =new List<DepartmentModel>();

            foreach(var item in data)
            {
                depts.Add(new DepartmentModel()

                {
                    Id = item.Id,
                    Name = item.Name

               });
            }
            return depts;

        }

        public static DepartmentModel Get(int id)
        {

            var data = DataAccessFactory.DepartmentDataAccess().Get(id);
            var depts = new DepartmentModel()
            {
                Id = data.Id,
                Name = data.Name
            };
            return depts;

            
        }

        public static bool Create(DepartmentModel obj)
        {
            var depts = new Department();
            {
                depts.Id = obj.Id;
            depts.Name = obj.Name;
                return DataAccessFactory.DepartmentDataAccess().Create(depts);
            }
           
        }
    }
}
