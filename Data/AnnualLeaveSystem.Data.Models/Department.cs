namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class Department : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        // public int ManagerId { get; set; }

        // public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
