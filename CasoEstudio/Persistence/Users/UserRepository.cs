using Application.Contexts;
using Application.Users;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Users
{

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {


        public UserRepository(AplicationDbContext context)
            : base(context)
        { }



    }
}
