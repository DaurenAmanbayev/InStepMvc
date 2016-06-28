using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models.Dictionaries
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string CountryName { get; set; }
    }
}