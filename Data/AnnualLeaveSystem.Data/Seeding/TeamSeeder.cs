namespace AnnualLeaveSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AnnualLeaveSystem.Data.Models;

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
