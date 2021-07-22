using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devops_test_api.Models
{
    public class Person
    {
        public Person()
        {

        }
         public Person(int person_id, int balance, string name, string email_id)
        {
            this.person_id = person_id;
            this.balance = balance;
            this.name = name;
            this.email_id = email_id;
        }
        public int person_id { get; set; }
        public int balance { get; set; }
        public string name { get; set; }
        public string email_id { get; set; }
    }
}
