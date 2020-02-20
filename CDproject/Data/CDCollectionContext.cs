using System;
using CDproject.Models;
using Microsoft.EntityFrameworkCore;

namespace CDproject.Data
{
    public class CDCollectionContext : DbContext
    {
        public CDCollectionContext(DbContextOptions<CDCollectionContext> options) : base(options)
        {
        }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<User> User { get; set; }
    }
}
