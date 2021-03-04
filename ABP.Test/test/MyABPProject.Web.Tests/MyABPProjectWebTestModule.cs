using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.EntityFrameworkCore;
using MyABPProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyABPProject.Web.Tests
{
    [DependsOn(
        typeof(MyABPProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyABPProjectWebTestModule : AbpModule
    {
        public MyABPProjectWebTestModule(MyABPProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyABPProjectWebMvcModule).Assembly);
        }
    }
}