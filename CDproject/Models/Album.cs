using System;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class Album
    {
        //Properties
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Välj namn på artist!")]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Välj namn på album!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Välj namn på användare!")]
        public int UserId { get; set; }

        public Album()
        {
        }
    }
}
