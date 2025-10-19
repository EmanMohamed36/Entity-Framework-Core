using Microsoft.EntityFrameworkCore;
using RelationShipsBetweenEmployeeAndDepartment.Data;

namespace RelationShipsBetweenEmployeeAndDepartment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
