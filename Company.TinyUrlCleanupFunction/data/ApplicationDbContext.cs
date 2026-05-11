using Company.TinyUrlCleanupFunction.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TinyUrlCleanupFunction.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}