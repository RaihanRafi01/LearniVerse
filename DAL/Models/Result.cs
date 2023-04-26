using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Result
    {
        //result - result_id, marks, grade, status, comment

        public int Id { get; set; }

        public float Mark { get; set; }

        public string Grade { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }

        public virtual ICollection<QuizResult> QuizResults { get; set; }
        public Result()
        {
            QuizResults = new List<QuizResult>();

        }
    }
}
