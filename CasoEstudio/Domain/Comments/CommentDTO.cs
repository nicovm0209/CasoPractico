using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Comments
{
    public class CommentDTO
    {
        public CommentDTO()
        {

        }

        public CommentDTO(int id, string Content)
        {
            Id = id;
            
            Content = Content;
        }

        public int Id { get; set; }
       
        public string Content { get; set; }
    }
}
