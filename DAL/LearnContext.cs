using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class LearnContext : DbContext
    {
        //Rafi
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Ques> ques { get; set; }

        //Sufian
        public DbSet<Student> students { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Salary> salarys { get; set; }


        //mushfiq
        public DbSet<Guardian> guardians { get; set; }

        public DbSet<Result> results { get; set; }

        public DbSet<Admin> admins { get; set; }

        // AUTH

        public DbSet<TokenTeacher> tokenTeachers { get; set; }

    }
}
