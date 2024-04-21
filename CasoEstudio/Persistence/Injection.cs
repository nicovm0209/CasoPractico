using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Courses;
using Persistence.Repositories;
using Persistence.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class Injection
{
    public static IServiceCollection AddPersistenceServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AplicationDbContext>
            (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

        services.AddScoped<IAplicationDbContext>
            (options => options.GetService<AplicationDbContext>());

        services.AddRepository<User, IUserRepository, UserRepository>();
        services.AddRepository<Post, IPostRepository, PostRepository>();
        services.AddRepository<Comment, ICommentRepository, CommentRepository>();

            return services;
    }
}
}
