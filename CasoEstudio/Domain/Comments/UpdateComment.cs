using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Comments
{
   public class UpdateComment
    {

        public int CommentId { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }
        
        public string Content { get; set; }

        
        public bool Active { get; set; }
    }
}
