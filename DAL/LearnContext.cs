using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LearnContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
