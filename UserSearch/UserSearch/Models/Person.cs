using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserSearch.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string address { get; set; }

        public int age { get; set; }

        public string imgURL { get; set; }
    }
}