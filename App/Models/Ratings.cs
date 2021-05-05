using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Ratings
    {

        [Key]
        public int ID { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }
    }
}
