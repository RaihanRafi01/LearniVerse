using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StGuDTO
    {
        public int Id { get; set; }
        
        public int Sid { get; set; }
        public virtual Student Student { get; set; }
       
        public int Gid { get; set; }
        public virtual Guardian Guardian { get; set; }
        
        public int Tid { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
