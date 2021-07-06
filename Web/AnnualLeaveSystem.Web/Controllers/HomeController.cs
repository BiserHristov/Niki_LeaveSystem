namespace AnnualLeaveSystem.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using AnnualLeaveSystem.Data;
    using AnnualLeaveSystem.Data.Common.Repositories;
    using AnnualLeaveSystem.Data.Models;
    using AnnualLeaveSystem.Services.Data;
    using AnnualLeaveSystem.Web.ViewModels;
    using AnnualLeaveSystem.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IGetCountService getCountService;

        public HomeController(IGetCountService getCountService)
        {
            this.getCountService = getCountService;
        }

        public IActionResult Index()
        {
            var dtoModel = this.getCountService.GetCount();
            var viewModel = new IndexViewModel
            {
                DepartmentsCount = dtoModel.DepartmentsCount,
                EmployeesCount = dtoModel.EmployeesCount,
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
