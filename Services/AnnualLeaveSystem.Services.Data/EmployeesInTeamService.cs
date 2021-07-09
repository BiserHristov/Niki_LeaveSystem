namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Repositories;
    using AnnualLeaveSystem.Data.Models;

    public class EmployeesInTeamService : IEmployeesInTeamService
    {
        private readonly IDeletableEntityRepository<Employee> employeeRepository;

        public EmployeesInTeamService(IDeletableEntityRepository<Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllEmployeesInTeam()
        {
            return this.employeeRepository
                .AllAsNoTracking()
                .Where(e => e.TeamId == 1) // TODO: Take the current user teamId!!!
                .Select(e => new
                {
                    Id = e.Id,
                    Name = $"{e.FirstName} {e.MiddleName} {e.LastName}",
                })
                .ToList()
            .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
