namespace AnnualLeaveSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Models;

    public class Employee : BaseDeletableModel<int>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public byte[] Image { get; set; }

        public string JobTitle { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public int? TeamLeadId { get; set; }

        public Employee TeamLead { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }


        public DateTime HireDate { get; set; }

        [InverseProperty("RequestEmployee")]
        public virtual ICollection<Leave> Leaves { get; set; } = new HashSet<Leave>();
    }
}
