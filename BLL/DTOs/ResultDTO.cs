using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ResultDTO
    {
        public int Id { get; set; }

        public float Mark { get; set; }

        public string Grade { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }
    }
}
