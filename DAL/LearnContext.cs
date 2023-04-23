using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class LearnContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Ques> ques { get; set; }


        public DbSet<Student> students { get; set; }
        public DbSet<Payment> payments { get; set; }
    }
}
