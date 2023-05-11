using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        public virtual ICollection<StudentGuardianTeacher> StGus { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<QuizResult> QuizResults { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Student()
        {
            StGus = new List<StudentGuardianTeacher>();
            Payments = new List<Payment>();
            QuizResults = new List<QuizResult>();
            Courses = new List<Course>();

        }

       
       

    }
}
