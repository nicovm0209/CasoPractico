using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Users
{

    public class User : Entity
    {

        public User()
        {

        }

        public static User Create
            (int id, string UserId, string Name,  string Email, string Pass,
                    bool active)
        {
            return new()
            {
                Id = UserId,
               
                Name = Name,
                Email = email,
                PhoneNumber = pass,
                
                Active = active

            };
        }

        public static User Create
            (int id, User user)
        {
            return new()
            {
                UserId = UserId,
               
               Name = user.Name,
               
                Email = user.Email,
               Pass = user.Pass

                Active = user.Active

            };
        }

        [Key]
        [JsonPropertyName("id")]
        public int Id { get; private set; }


        public string MyProperty { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(150, MinimumLength = 5)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(15, MinimumLength = 8)]
        [JsonPropertyName("pass")]
        public string Pass { get; set; }

        [Required]
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        
        //Revisar
        public List<Course> Courses { get; private set; }


    }
}
