namespace AnnualLeaveSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AnnualLeaveSystem.Data.Models;

    public class EmployeeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Employees.Any())
            {
                return;
            }

            await dbContext.Employees.AddAsync(new Employee { FirstName = "Peter", LastName = "Petrov", DepartmentId = 2, TeamId = 1 });
            await dbContext.Employees.AddAsync(new Employee { FirstName = "Ivan", LastName = "Inanov", DepartmentId = 1, TeamId = 1});
            await dbContext.Employees.AddAsync(new Employee { FirstName = "Stoyan", LastName = "Stoyanov", DepartmentId = 3, TeamId = 2});

            await dbContext.SaveChangesAsync();
        }
    }
}
