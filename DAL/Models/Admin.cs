﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        //admin - admin_id, name, email, gender, contact number, address,

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }     
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }


    }
}
