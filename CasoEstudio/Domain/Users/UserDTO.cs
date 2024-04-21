using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class UserDTO
    {
        public UserDTO()
        {
        }

        public UserDTO(int UserId,string Name)
        {
            Id = UserId;
            
            Name = Name;
        }

        public int Id { get; set; }
       
        public string Name { get; set; }
    }
}
