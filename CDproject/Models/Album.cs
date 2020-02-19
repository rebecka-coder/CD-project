using System;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class Album
    {
        //Properties
        [Key]
        public int Id { get; set; }

        public int ArtistId { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int UsernameId { get; set; }

        public Album()
        {
        }
    }
}
