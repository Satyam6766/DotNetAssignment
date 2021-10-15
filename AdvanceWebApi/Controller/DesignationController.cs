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
    public class DesignationController : ControllerBase
    {
        private readonly IDesignationRepsitory _repository;
        public DesignationController(IDesignationRepsitory repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
          var response=_repository.GetDesignations();
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
        public IActionResult Get(int id)
        {
            var response = _repository.GetDesignation(id);
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
        public IActionResult Insert(Designation designation)
        {
            var response = _repository.Insert(designation);
            if(response== "Designation saved successfully.")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
        [HttpPut]
        public IActionResult Put(int id,Designation designation)
        {
            var response = _repository.Update(id, designation);
            if (response == "Designation record  updated successfully")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = _repository.Delete(id);
            if (response == "Designation record deleted successfully.")
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
