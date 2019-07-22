using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Blazor.Club.Configuration;

namespace Blazor.Club.Web.Host.Startup
{
    [DependsOn(
       typeof(ClubWebCoreModule))]
    public class ClubWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ClubWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClubWebHostModule).GetAssembly());
        }
    }
}
