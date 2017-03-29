using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheNicestWebApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }


        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Persons { get; set; }
    }
}
