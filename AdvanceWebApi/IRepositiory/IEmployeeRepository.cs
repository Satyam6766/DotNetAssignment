using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebApi.Models;
using AdvanceWebApi.IRepositiory;


namespace AdvanceWebApi.IRepositiory
{
    public interface IEmployeeRepository
    {
        public IEnumerable<GetEmployeeView> GetEmployees();
        public GetEmployeeView GetEmployee(int id);
        public string Insert(Employee employee);
        public string Update(int id, Employee employee);
        public string Delete(int id);

    }
}
