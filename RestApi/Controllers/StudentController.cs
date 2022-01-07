using RestApi.Models;
using System;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class StudentController : ApiController
    {
        [HttpPost]
        public bool AddStudentDetails()
        {
            return true;
            // insert in database

        }
        [HttpGet]
        public StudentModel[] Get()
        {
            return new StudentModel[]
            {
                new StudentModel
                {
                    id = 1,
                    firstname = "sam",
                    lastname = "studentONE",
                    address = "Port louis",
                    age = 23
                },
                new StudentModel
                {
                    id = 2,
                    firstname = "John",
                    lastname = "studentTWO",
                    address = "Pamplemousses",
                    age = 30
                },
                new StudentModel
                {
                    id = 3,
                    firstname = "Alex",
                    lastname = "studentTHREE",
                    address = "Terre Rouge",
                    age = 42
                }
            };
        }


        [HttpDelete]
        public string DeleteStudentDetails(string id)
        {
            return "Student details deleted having Id " + id;

        }
    }
}