using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class BookModel
    {
        [Key]
        public int ID {get;set;}
        [Required]
        public string ?Title{get;set;}

       [Required]
        public string ?Author {get;set;}
        [Required]
        public int Price {get;set;}

    }
}