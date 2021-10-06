using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.ComponentModel;

namespace EF_Exercise1_06Sep2021.Controllers
{
    public class CustomerController : ApiController
    {

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            using (var context = new EFBootcampEntities())
            {
                //var customerData = context.Customers.ToList();
                var customerData = (from cust in context.Customers
                                    join o in context.OrderDetails on cust.id equals o.CustID
                                    select new
                                    {
                                        cust.id,
                                        cust.name,
                                        cust.city,
                                        cust.address,
                                        o.CustID,
                                        o.PID
                                    }).ToList();


                return Ok(customerData);
            }
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            using (var context = new EFBootcampEntities())
            {

                var custData = (from od in context.OrderDetails
                                join cust in context.Customers on od.CustID equals cust.id
                                join pr in context.Products on od.PID equals pr.PID
                                where od.CustID == id
                                select new
                                {
                                    name = cust.name,
                                    city = cust.city,
                                    address = cust.address,
                                    orderdate = cust.orderDate,
                                    productName = pr.PName,
                                    price = pr.PPrice
                                }).ToList();
                return Ok(custData);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Customer value)
        {
            using (var context = new EFBootcampEntities())
            {
                context.Customers.Add(value);
                context.SaveChanges();
                return Ok("Customer inserted successfully.");
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] Customer value)
        {
            using (var context = new EFBootcampEntities())
            {
                var response = (from cust in context.Customers
                                where cust.id == id
                                select cust
                              ).ToList();
                if (response != null)
                {
                    foreach (var row in response)
                    {

                        row.name = value.name;
                        row.city = value.city;
                        row.address = value.address;

                    }
                    context.SaveChanges();
                    return Ok("Updated successfully");
                }
                return BadRequest("Modification failed");
            }

        }

        // DELETE api/<controller>/5

        public IHttpActionResult Delete(int id)
        {

            using (var context = new EFBootcampEntities())
            {

                var response = (from cust in context.Customers
                                where cust.id == id
                                select cust).FirstOrDefault();

                if (response != null)
                {
                    context.Customers.Remove(response);
                    context.SaveChanges();
                    return Ok("Recore deleted Successfully");
                }

                return BadRequest("Customer with the given ID does not exists");
            }
        }
    }
}