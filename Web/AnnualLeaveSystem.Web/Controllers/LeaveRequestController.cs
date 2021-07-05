namespace AnnualLeaveSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AnnualLeaveSystem.Web.ViewModels.LeaveRequest;
    using Microsoft.AspNetCore.Mvc;

    public class LeaveRequestController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
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
