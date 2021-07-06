namespace AnnualLeaveSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AnnualLeaveSystem.Services.Data;
    using AnnualLeaveSystem.Web.ViewModels.LeaveRequest;
    using Microsoft.AspNetCore.Mvc;

    public class LeaveRequestController : Controller
    {
        private readonly ILeaveTypeService leaveTypeService;
        private readonly IEmployeesInTeamService employeesInTeamService;

        public LeaveRequestController(ILeaveTypeService leaveTypeService, IEmployeesInTeamService employeesInTeamService)
        {
            this.leaveTypeService = leaveTypeService;
            this.employeesInTeamService = employeesInTeamService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateLeaveRequestInputModel
            {
                LeaveTypes = this.leaveTypeService.GetAllLeaveTypes(),
                EmployeesInTeam = this.employeesInTeamService.GetAllEmployeesInTeam(),
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateLeaveRequestInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            // TODO: Redirect to Leave request info page
            return this.Redirect("/");
        }
    }
}
