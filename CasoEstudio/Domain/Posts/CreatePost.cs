﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Posts
{
   public class CreatePost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        
        public string Like { get; set; }

        public string Dislike { get; set; }
    }
}
