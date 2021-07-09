namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ILeaveTypeService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllLeaveTypes();
    }
}
