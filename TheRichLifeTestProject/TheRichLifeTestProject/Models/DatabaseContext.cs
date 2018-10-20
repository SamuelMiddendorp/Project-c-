using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TheRichLifeTestProject.Models;

namespace TheRichLifeTestProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Atribute> Atributes { get; set; }
        public DbSet<Value> Values { get; set; }
    
    }
}