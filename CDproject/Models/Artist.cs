using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class Artist
    {
        //Properties
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Välj namn på artist!")]
        public string Name { get; set; }
 

        public ICollection<Album> Albums { get; set; }

    }
   
}
