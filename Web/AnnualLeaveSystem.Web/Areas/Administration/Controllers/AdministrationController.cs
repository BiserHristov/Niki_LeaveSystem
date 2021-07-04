namespace AnnualLeaveSystem.Web.Areas.Administration.Controllers
{
    using AnnualLeaveSystem.Common;
    using AnnualLeaveSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
