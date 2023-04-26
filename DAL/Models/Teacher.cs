using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }


        public virtual ICollection<Ques> Ques { get; set; }
        public virtual ICollection<StGu> StGus { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public Teacher()
        {
            StGus = new List<StGu>();
            Ques = new List<Ques>();
            Salaries = new List<Salary>();
            Courses = new List<Course>();

        }

    }
}
