using devops_test_api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devops_test_api.Controllers
{
    [ApiController]
    [Route("api/person")]
    public class CrudController: ControllerBase
    {
        private static List<Person> persons = new List<Person>{
        new Person {person_id = 1, balance =  1000, name  =  "Anurag Agrawal", email_id = "anurag.agrawal@lntinfotech.com" },
               new Person {person_id = 2, balance =  1000, name  =  "Murtuza Patel", email_id = "murtuza.patel@lntinfotech.com" },
               new Person {person_id = 3, balance =  1000, name  =  "Vineet Bakshi", email_id = "vineet.bakshi@lntinfotech.com" },
               new Person {person_id = 4, balance =  1000, name  =  "Astha Chaudhary", email_id = "astha.chaudhary@lntinfotech.com" }
        };


            //persons.Add( new Person(1, 1000, "Anurag Agrawal", "anurag.agrawal@lntinfotech.com"));
            //persons.Add(new Person(2, 1030, "Murtuza Patel", "murtuza.patel@lntinfotech.com"));
            //persons.Add(new Person(3, 1200, "Vineet Bakshi", "vineet.bakshi@lntinfotech.com"));
            //persons.Add(new Person(4, 1400, "Astha Chaudhary", "astha.chaudhary@lntinfotech.com"));


        [HttpPost]
        public ActionResult<Person> AddUser(Person person)
        {
            try
            {
                persons.Add(person);
                return person;
            }
            catch
            {
                return BadRequest();
            }

        }
 
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Users()
        {
            //Console.WriteLine(persons.Count());
            return persons.ToArray();
        }

        [HttpPut]

        public ActionResult<Person> EditUser(Person person)
        {
            try
            {
                var a = persons.Find(x => x.person_id == person.person_id);
                persons.Remove(a);
                persons.Add(person);
                return person;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete]

        public ActionResult<Person> DeleteUser(Person person)
        {
            try
            {
                var a = persons.Find(x => x.person_id == person.person_id);
                if (a == null)
                    throw new Exception();
                persons.Remove(a);
              
                return person;
            }

            catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
