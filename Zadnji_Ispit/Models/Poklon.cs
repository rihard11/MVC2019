using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadnji_Ispit.Models
{
    public class Poklon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Ime ne smije biti vece od 50 znakova")]
        public string Naziv { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal Cijena { get; set; }

        public bool Kupljeno { get; set; }
    }
}