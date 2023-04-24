using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenTeacherDTO
    {

        public string TKey { get; set; }      
        public DateTime Createtime { get; set; }
        public DateTime? ExpireTime { get; set; }
       
        public string UserName { get; set; }
    }
}
