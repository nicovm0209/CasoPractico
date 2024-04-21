using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Posts
{
    public class PostDTO
    {
        public PostDTO () 
        { 
        }

        public PostDTO(int id, string Title)
        {
            Id = id;

            Title = Title;
        }

        public int Id { get; set; }
        
        public string Title { get; set; }
    }
}
