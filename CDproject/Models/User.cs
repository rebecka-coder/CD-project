using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Välj namn på användare!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Välj datum!")]
        public int Date { get; set; }

        public ICollection<Album> Albums { get; set; }

    }
}
