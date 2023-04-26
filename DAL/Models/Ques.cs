using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ques
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAns { get; set; }

        [ForeignKey("Teacher")]
        [Required]
        public int Tid { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<QuizResult> QuizResults { get; set; }
        public Ques()
        {
            QuizResults = new List<QuizResult>();

        }

    }
}
