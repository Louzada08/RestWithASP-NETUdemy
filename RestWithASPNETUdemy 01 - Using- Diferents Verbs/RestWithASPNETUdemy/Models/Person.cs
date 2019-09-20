using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Models
{
    //[Table("persons")]
    public class Person
    {
        //[Column("FirstName")]
        public string FirstName { get; set; }

        //[Column("LastName")]
        public string LastName { get; set; }

        //[Column("Address")]
        public string Address { get; set; }

        //[Column("Gender")]
        public string Gender { get; set; }
    }
}
