using OrganizationManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Interfaces
{
    public interface IOrganizationManagement
    {
        public List<FacultyModel> GetAllFacultyList();
        public List<FacultyModel> GetAllFacultyList(string temp);
        public Task AddFaculty(FacultyModel objFact);
        public Task DeleteFaculty(int id);
        public List<DepartmentsModel> LoadDepartment();
        //Task<FacultyModel> GetFacultyDtls(FacultyModel objfact);
    }
}
