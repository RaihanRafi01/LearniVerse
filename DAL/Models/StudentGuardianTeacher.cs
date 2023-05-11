using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class StudentGuardianTeacher
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int Sid { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Guardian")]
        public int Gid { get; set; }
        public virtual Guardian Guardian { get; set; }
        [ForeignKey("Teacher")]
        public int Tid { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
