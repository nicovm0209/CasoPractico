using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Posts
{
    public class Post
    {
        public Post() 
        { 
        }

        public static Post Create
            (int postId, int userId, string title, string content, string like, string dislike,
                    bool active)
        {
            return new()
            {
                Id = postId,
                UserId = userId,
                Title = title,
                Content = content,
                Like = like,
                Dislike = dislike,
                Active = active

            };
        }

        public static Post Create
            (int id, Post post)
        {
            return new()
            {
                Id = id,
                UserId = post.UserId,
                Title = post.title,
                Content = post.content,
                Like = post.like,
                Dislike = post.dislike,
                Active = post.Active
            };
        }

        [Key]
        [JsonPropertyName("id")]
        public int Id { get; private set; }


        public string MyProperty { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [JsonPropertyName("like")]
        public string Like { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [JsonPropertyName("dislike")]
        public string Dislike { get; set; }

        [Required]
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        
        //revisar
        public List<Course> Courses { get; private set; }


    }
}
