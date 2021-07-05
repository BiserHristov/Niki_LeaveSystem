namespace AnnualLeaveSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AnnualLeaveSystem.Data.Models;

    public class DepartmentSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Departments.Any())
            {
                return;
            }

            await dbContext.Departments.AddAsync(new Department { Name = "Finance" });
            await dbContext.Departments.AddAsync(new Department { Name = "IT" });
            await dbContext.Departments.AddAsync(new Department { Name = "Logistic" });
            await dbContext.Departments.AddAsync(new Department { Name = "HR" });

            await dbContext.SaveChangesAsync();
        }
    }
}
