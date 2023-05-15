using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public string TeacherName { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("Teacher")]
        [Required]
        public int Tid { get; set; }

        public virtual Teacher Teacher { get; set; }

        [ForeignKey("Student")]
        [Required]
        public int Sid { get; set; }

        public virtual Student Student { get; set; }
    }
}
