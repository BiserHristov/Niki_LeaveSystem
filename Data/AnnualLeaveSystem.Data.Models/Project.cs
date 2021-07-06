namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class Project : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
