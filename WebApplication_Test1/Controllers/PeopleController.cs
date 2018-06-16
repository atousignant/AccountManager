using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_Test1.DB;

namespace WebApplication_Test1.Controllers
{
    public class PeopleController : ApiController
    {
        // GET: api/People
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return new Person { Id = id, Birthday = DateTime.Now.AddYears(-20), Name = "TestName" };
        }

        [Route("api/People/GetFirstNames")]
        public List<string> GetFirstNames()
        {
            var test = DB.DB.Instance;

            List<string> output = new List<string>();

            output.Add("Test1");
            output.Add("Test2");
            output.Add("Test3");
            output.Add("Test4");
            output.Add("Test5");


            return output;
        }

        // POST: api/People
        public void Post(Person value)
        {
            var i = value;


        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

}
