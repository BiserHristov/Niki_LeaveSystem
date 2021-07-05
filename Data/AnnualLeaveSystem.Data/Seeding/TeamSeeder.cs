using AnnualLeaveSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeaveSystem.Data.Seeding
{
    public class TeamSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Teams.Any())
            {
                return;
            }

            await dbContext.Teams.AddAsync(new Team { ProjectId = 2, });
            await dbContext.Teams.AddAsync(new Team { ProjectId = 1 });

            await dbContext.SaveChangesAsync();
        }
    }
}
