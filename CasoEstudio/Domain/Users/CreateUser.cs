﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{


    public class CreateUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string UserId { get; set; }
    }
}
