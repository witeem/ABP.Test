using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP.Test.Authorization.Roles;
using ABP.Test.Authorization.Users;
using ABP.Test.MultiTenancy;

namespace ABP.Test.EntityFrameworkCore
{
    public class TestDbContext : AbpZeroDbContext<Tenant, Role, User, TestDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }
    }
}
