using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Blazor.Club.Configuration;
using Blazor.Club.Web;

namespace Blazor.Club.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ClubDbContextFactory : IDesignTimeDbContextFactory<ClubDbContext>
    {
        public ClubDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClubDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ClubDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ClubConsts.ConnectionStringName));

            return new ClubDbContext(builder.Options);
        }
    }
}
