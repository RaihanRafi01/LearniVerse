using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Search
    {
        [Key]
        public int Id { get; set; }
        public string SearchName { get; set; }
        public int Count { get; set; }
    }
}
