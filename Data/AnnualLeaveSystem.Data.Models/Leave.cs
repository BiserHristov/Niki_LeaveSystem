namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class Leave : BaseDeletableModel<int>
    {
        public DateTime AppliedOn { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; }

        public int RequestEmployeeId { get; set; }

        public Employee RequestEmployee { get; set; }

        public int ApproveEmployeeId { get; set; }

        public Employee ApproveEmployee { get; set; }

        public bool IsApproved { get; set; } = false;

        public bool IsCancelled { get; set; } = false;

        public string RequestComments { get; set; }
    }
}
