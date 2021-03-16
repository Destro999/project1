using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class SignUpDbContext : DbContext
    {
        public SignUpDbContext (DbContextOptions<SignUpDbContext> options) : base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
