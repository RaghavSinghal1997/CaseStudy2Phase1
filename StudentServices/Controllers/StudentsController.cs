using StudentDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentServices.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<student> Get()
        {
            using (StudentDetailsEntities entities=new StudentDetailsEntities())
            {
                return entities.student.ToList();
            }
        }
        public student Get(int id)
        {
            using(StudentDetailsEntities entities=new StudentDetailsEntities())
            {
                return entities.student.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
