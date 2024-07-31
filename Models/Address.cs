using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.Models
{
    public class Address
    {
        [Key]
        public int Id { set; get; }
        public string Street {set; get;}
        public string City { set; get; }
        public string State { set; get; }
    }
}