namespace AnnualLeaveSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AnnualLeaveSystem.Data.Common.Repositories;
    using AnnualLeaveSystem.Data.Models;
    using AnnualLeaveSystem.Services.Data.DTOModels;
    using AnnualLeaveSystem.Web.ViewModels.Home;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<Employee> employeesRepository;
        private readonly IDeletableEntityRepository<Team> teamRepository;
        private readonly IDeletableEntityRepository<Project> projectRepository;
        private readonly IDeletableEntityRepository<Leave> leaveRepository;
        private readonly IDeletableEntityRepository<LeaveType> leaveTypeRepository;
        private readonly IDeletableEntityRepository<Department> departmentRepository;

        public GetCountService(
            IDeletableEntityRepository<Employee> employeesRepository,
            IDeletableEntityRepository<Team> teamRepository,
            IDeletableEntityRepository<Project> projectRepository,
            IDeletableEntityRepository<Leave> leaveRepository,
            IDeletableEntityRepository<LeaveType> leaveTypeRepository,
            IDeletableEntityRepository<Department> departmentRepository)
        {
            this.employeesRepository = employeesRepository;
            this.teamRepository = teamRepository;
            this.projectRepository = projectRepository;
            this.leaveRepository = leaveRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            this.departmentRepository = departmentRepository;
        }

        public CountsDTO GetCount()
        {
            var data = new CountsDTO
            {
                DepartmentsCount = this.departmentRepository.All().Count(),

                EmployeesCount = this.employeesRepository.All().Count(),
            };

            return data;
        }
    }
}
