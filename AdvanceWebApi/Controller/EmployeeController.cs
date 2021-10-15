using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebApi.IRepositiory;
using AdvanceWebApi.Models;
using AdvanceWebApi.Repository;

namespace AdvanceWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _repository.GetEmployees();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Record not found.");
            }

        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var response = _repository.GetEmployee(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Record not found.");
            }
        }
        [HttpPost]
        public ActionResult Insert(Employee employee)
        {
            var response = _repository.Insert(employee);
            if (response == "Employee saved successfully.")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
        [HttpPut]
        public ActionResult Update(int id,Employee employee)
        {
            var response = _repository.Update(id,employee);
            if (response == "Employee updated successfully")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var response = _repository.Delete(id);
            if (response == "Employee Record Deleted Successfully.")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
