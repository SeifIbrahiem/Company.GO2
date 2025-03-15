using Company.GO2.DAL.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.GO2.BLL.Interface
{
    public interface IDepartmentRepository
    {
       IEnumerable<Department> Getall();
        Department? Get(int id);

        int Add(Department model);

        int Update(Department model);

        int Delete(Department model);
    }
}
