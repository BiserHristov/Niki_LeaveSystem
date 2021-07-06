namespace AnnualLeaveSystem.Web.ViewModels.LeaveRequest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CreateLeaveRequestInputModel
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveType { get; set; }

        public string ReplacementEmployee { get; set; }

        public string RequestComments { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LeaveTypes { get; set; }

        public IEnumerable<KeyValuePair<string, string>> EmployeesInTeam { get; set; }
    }
}
