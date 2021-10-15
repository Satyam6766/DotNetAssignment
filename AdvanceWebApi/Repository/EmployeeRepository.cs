using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebApi.Models;
using AdvanceWebApi.IRepositiory;


namespace AdvanceWebApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly AdvanceWebApiContext _context;
        public EmployeeRepository(AdvanceWebApiContext context)
        {
            _context = context;
        }
        public string Delete(int id)
        {
            string str;
            var response = _context.Employees.FirstOrDefault(x => x.Id == id);
            try
            {

                if (response != null)
                {
                    _context.Employees.Remove(response);
                    _context.SaveChanges();
                    str = "Employee Record Deleted Successfully.";
                }
                else
                {
                    str = "Employee not found.";
                }
            }
            catch (Exception ex)
            {
                str = "Deletion Failed due to=" + ex.Message + ".";
            }
            return str;

        }

        public GetEmployeeView GetEmployee(int id)
        {
            var response = (from emp in _context.Employees
                            join d in _context.Designations
                            on emp.DesignationId equals d.DesgId
                            where emp.Id == id
                            select new GetEmployeeView
                            {
                                Id = emp.Id,
                                Name = emp.Name,
                                Department = emp.Department,
                                Gender = emp.Gender,
                                DesignationId = d.DesgId,
                                DesgName = d.DesgName,
                                salary = (double)d.DesgSalary
                            }).FirstOrDefault();
            return response;
        }

        public IEnumerable<GetEmployeeView> GetEmployees()
        {
            var response = from emp in _context.Employees
                           join d in _context.Designations
                           on emp.DesignationId equals d.DesgId
                           select new GetEmployeeView
                           {
                               Id = emp.Id,
                               Name = emp.Name,
                               Department=emp.Department,
                               Gender = emp.Gender,
                               DesignationId = d.DesgId,
                               DesgName = d.DesgName,
                               salary = (double)d.DesgSalary
                           };
            return response;
        }

        public string Insert(Employee employee)
        {
            string str;
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                str = "Employee saved successfully.";
            }
            catch (Exception ex)
            {
                str = "Employee insertion Failed due to this error" + ex.Message;
            }
            return str;
        }

        public string Update(int id, Employee employee)
        {
            string str;
            var response = _context.Employees.FirstOrDefault(x => x.Id == id);
            try
            {
                if (response != null)
                {
                    response.Name = employee.Name;
                    response.Department = employee.Department;
                    response.Gender = employee.Gender;
                    response.DesignationId = employee.DesignationId;
                    _context.SaveChanges();
                    str = "Employee updated successfully";
                }
                else
                {
                    str = "Employee not found for the given id" + id + ".";
                }
            }
            catch (Exception ex)
            {
                str = "Updation failed due to this error=" + ex.Message + ".";
            }
            return str;


        }
    }
}
