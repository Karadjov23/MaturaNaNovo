using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Animal> Animals{ get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Signal> Signals { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}
