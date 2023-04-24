using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TokenTeacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TKey { get; set; }
        [Required]
        public DateTime Createtime { get; set; }
        public DateTime? ExpireTime { get; set; }
        [Required]
        public string UserId { get; set; }

    }
}
