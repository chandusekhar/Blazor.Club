using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Club.EntityFrameworkCore
{
    public static class ClubDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ClubDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ClubDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
