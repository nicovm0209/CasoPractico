using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Posts
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(AplicationDbContext context)
            : base(context)

        { }
    }
}