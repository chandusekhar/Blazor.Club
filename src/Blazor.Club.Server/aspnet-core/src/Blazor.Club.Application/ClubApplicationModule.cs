using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blazor.Club.Authorization;

namespace Blazor.Club
{
    [DependsOn(
        typeof(ClubCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ClubApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ClubAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ClubApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
