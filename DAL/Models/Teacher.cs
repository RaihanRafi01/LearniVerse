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
        [ForeignKey("Ques")]
        public int QId { get; set; }
        public virtual Ques Ques { get; set; }

        [ForeignKey("Course")]
        public int CId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Student")]
        public int SId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Guardian")]
        public int GId { get; set; }
        public virtual Guardian Guardian { get; set; }

    }
}
