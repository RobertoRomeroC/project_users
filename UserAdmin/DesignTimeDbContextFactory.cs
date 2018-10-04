using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UserAdmin.Data;

namespace UserAdmin
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<UserAdminContext>
    {
        public UserAdminContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();

            var builder = new DbContextOptionsBuilder<UserAdminContext>();

            var connectionString = configuration.GetConnectionString("UsersAdminConnectionString");

            builder.UseSqlServer(connectionString);

            return new UserAdminContext(builder.Options);
        }
    }
}
