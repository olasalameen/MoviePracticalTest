using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class SearchMovies
    {
        [Key]
        public int ID { get; set; }
        public string Movies{ get; set; }
        }
}
