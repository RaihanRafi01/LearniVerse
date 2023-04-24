using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public virtual ICollection<Teacher> Teachers { get; set; }
        public Student()
        {
            Teachers = new List<Teacher>();
        }
    }
}
