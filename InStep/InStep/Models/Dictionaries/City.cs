using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models.Dictionaries
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string CityName { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}