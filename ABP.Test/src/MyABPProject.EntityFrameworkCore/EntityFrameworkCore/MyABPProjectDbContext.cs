using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABPProject.Authorization.Roles;
using MyABPProject.Authorization.Users;
using MyABPProject.MultiTenancy;

namespace MyABPProject.EntityFrameworkCore
{
    public class MyABPProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyABPProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyABPProjectDbContext(DbContextOptions<MyABPProjectDbContext> options)
            : base(options)
        {
        }
    }
}
