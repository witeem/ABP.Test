using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP.Test.EntityFrameworkCore
{
    public static class TestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
