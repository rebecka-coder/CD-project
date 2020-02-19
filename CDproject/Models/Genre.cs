using System;
using System.ComponentModel.DataAnnotations;

namespace CDproject.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }

        public Genre()
        {

        }
    }
}
