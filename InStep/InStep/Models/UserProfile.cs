using InStep.Models.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InStep.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        // Местоположение
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }

        // Контакты
        public string AdditionalPhone { get; set; }
        public string Skype { get; set; }
        public string Twitter { get; set; }
        public string OwnerSite { get; set; }

        // Интересы
        public string Interest { get; set; }
        public string FavoriteMusic { get; set; }
        public string FavoriteFilms { get; set; }
        public string FavoriteBooks { get; set; }
        public string FavoriteGames { get; set; }
        public string About { get; set; }
    }
}