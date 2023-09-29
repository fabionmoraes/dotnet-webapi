using dotnet.src.Domain.Model.CompanyAggregate;
using dotnet.src.Domain.Model.EmployeeAggregate;
using Microsoft.EntityFrameworkCore;

namespace dotnet.src.infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var conection = "server=localhost;port=8889;database=dotnet;uid=root;password=root;";
                options.UseMySql(conection, ServerVersion.AutoDetect(conection));
            }
        }
    }
}
