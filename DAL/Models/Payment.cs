using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        [ForeignKey("Student")]
        [Required]
        public int Sid { get; set; }

        public virtual Student Student { get; set; }
    }
}
