using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPProject.Authorization;

namespace MyABPProject
{
    [DependsOn(
        typeof(MyABPProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyABPProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyABPProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
