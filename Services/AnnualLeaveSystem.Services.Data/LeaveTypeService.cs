namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Repositories;
    using AnnualLeaveSystem.Data.Models;

    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly IDeletableEntityRepository<LeaveType> leaveTypeRepository;

        public LeaveTypeService(IDeletableEntityRepository<LeaveType> leaveTypeRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllLeaveTypes()
        {
            return this.leaveTypeRepository.AllAsNoTracking()
                 .Select(t => new
                 {
                     t.Id,
                     t.Name,
                 })
             .ToList()
             .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
