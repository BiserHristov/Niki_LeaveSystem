using System;
using System.Collections.Generic;
using System.Text;

namespace AnnualLeaveSystem.Web.ViewModels.LeaveRequest
{
    public class CreateLeaveRequestInputModel
    {

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveTypeId { get; set; }

        public string RequestComments { get; set; }
    }
}
