using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworks.Data;
using EntityFrameworks.Model;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace EntityFrameworks.Controllers
{
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using (var Employeecontext = new EmployeeContext())
            {
                var listofEemployees = new List<EmployeeEntities>();
                listofEemployees = Employeecontext.Employee.ToList();
                return Ok(listofEemployees);
            }
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
            //return "value";
        //}

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]EmployeeEntities EmployeeObject)
        {
            using (var Employeecontext = new EmployeeContext())
            {
                Employeecontext.Employee.Add(EmployeeObject);
                Employeecontext.SaveChanges();
            }
            return Ok("Employee Details Added");
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody]EmployeeEntities EmployeeObject)
        {
            using (var Employeecontext = new EmployeeContext())
            {
                Employeecontext.Employee.Update(EmployeeObject);
                Employeecontext.SaveChanges();
            }
            return Ok("Employee Details Updated");
        }

        // DELETE api/values/5
        [HttpDelete]
        public ActionResult Delete([FromBody]EmployeeEntities EmployeeObject)
        {
            using (var Employeecontext = new EmployeeContext())
            {
                Employeecontext.Employee.Remove(EmployeeObject);
                Employeecontext.SaveChanges();
            }
            return Ok("Employee Details Deleted");
        }
    }
}
