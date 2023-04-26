using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        [ForeignKey("Teacher")]
        [Required]
        public int Tid { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
