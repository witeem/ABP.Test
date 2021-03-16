using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.Configuration;

namespace MyABPProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyABPProjectWebCoreModule))]
    public class MyABPProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyABPProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectWebHostModule).GetAssembly());
        }
    }
}
