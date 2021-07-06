namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class LeaveType : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }

        public ICollection<Leave> Leaves { get; set; }
    }
}
