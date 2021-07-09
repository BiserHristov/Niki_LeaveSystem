namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AnnualLeaveSystem.Services.Data.DTOModels;
    using AnnualLeaveSystem.Web.ViewModels.Home;

    public interface IGetCountService
    {
        CountsDTO GetCount();
    }
}
