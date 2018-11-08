using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Adminpro.Models
{
    public class AdminproContext : DbContext
    {
        public AdminproContext (DbContextOptions<AdminproContext> options)
            : base(options)
        {
        }

        public DbSet<Adminpro.Models.Student> Student { get; set; }
    }
}
