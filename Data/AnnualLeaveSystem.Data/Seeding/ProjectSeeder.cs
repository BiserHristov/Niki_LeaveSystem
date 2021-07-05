namespace AnnualLeaveSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AnnualLeaveSystem.Data.Models;

    public class ProjectSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Projects.Any())
            {
                return;
            }

            await dbContext.Projects.AddAsync(new Project { Name = "InventoryProject", TeamId = 2 });
            await dbContext.Projects.AddAsync(new Project { Name = "BoyanaHouse", TeamId = 1 });

            await dbContext.SaveChangesAsync();
        }
    }
}
