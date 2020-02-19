using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int Date { get; set; }

        public ICollection<Album> Albums { get; set; }
        
    }
}
