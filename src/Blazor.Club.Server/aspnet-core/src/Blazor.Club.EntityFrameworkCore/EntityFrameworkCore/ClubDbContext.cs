using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Blazor.Club.Authorization.Roles;
using Blazor.Club.Authorization.Users;
using Blazor.Club.MultiTenancy;

namespace Blazor.Club.EntityFrameworkCore
{
    public class ClubDbContext : AbpZeroDbContext<Tenant, Role, User, ClubDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ClubDbContext(DbContextOptions<ClubDbContext> options)
            : base(options)
        {
        }
    }
}
