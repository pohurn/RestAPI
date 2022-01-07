using RestApi.Models;
using System;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
            //write insert logic  

        }
        [HttpGet]
        public EmployeeModel[] Get()
        {
            return new EmployeeModel[]
            {
                new EmployeeModel
                {
                    id = 1,
                    firstname = "sam",
                    lastname = "employeeONE",
                    address = "Port louis",
                    age = 23
                },
                new EmployeeModel
                {
                    id = 2,
                    firstname = "John",
                    lastname = "employeeTWO",
                    address = "Pamplemousses",
                    age = 30
                },
                new EmployeeModel
                {
                    id = 3,
                    firstname = "Alex",
                    lastname = "employeeTHREE",
                    address = "Terre Rouge",
                    age = 42
                }
            };
        }


        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
    }
}