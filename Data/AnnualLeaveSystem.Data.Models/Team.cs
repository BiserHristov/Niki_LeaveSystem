namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class Team : BaseDeletableModel<int>
    {

        public int ProjectId { get; set; }

        public Project Project { get; set; }


        public ICollection<Employee> Employees { get; set; }

    }
}
