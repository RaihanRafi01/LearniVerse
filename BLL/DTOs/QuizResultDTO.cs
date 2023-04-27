using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class QuizResultDTO
    {
        public int Id { get; set; }
        public int Qid { get; set; }
        public virtual Ques Ques { get; set; }
        public int Rid { get; set; }
        public virtual Result Result { get; set; }
        public int Sid { get; set; }
        public virtual Student Student { get; set; }
    }
}
