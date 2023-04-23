using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Guardian
    { //Guardian_id, Name, email, gender, photo, contac_number, address

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
