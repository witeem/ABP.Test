using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyABPProject.Configuration;
using MyABPProject.Web;

namespace MyABPProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyABPProjectDbContextFactory : IDesignTimeDbContextFactory<MyABPProjectDbContext>
    {
        public MyABPProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyABPProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyABPProjectConsts.ConnectionStringName));

            return new MyABPProjectDbContext(builder.Options);
        }
    }
}
