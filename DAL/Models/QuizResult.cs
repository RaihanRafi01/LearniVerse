 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class QuizResult
    {
        public int Id { get; set; }

        [ForeignKey("Ques")]
        [Required]
        public int Qid { get; set; }
        public virtual Ques Ques { get; set; }

        [ForeignKey("Result")]
        [Required]
        public int Rid { get; set; }
        public virtual Result Result { get; set; }

        [ForeignKey("Student")]
        [Required]
        public int Sid { get; set; }
        public virtual Student Student { get; set; }

    }
}
