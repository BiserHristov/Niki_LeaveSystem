using AnnualLeaveSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeaveSystem.Data.Seeding
{
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
