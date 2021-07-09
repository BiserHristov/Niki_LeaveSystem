namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IEmployeesInTeamService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllEmployeesInTeam();
    }
}
