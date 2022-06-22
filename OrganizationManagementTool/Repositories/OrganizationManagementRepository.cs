//using Dapper;
using Microsoft.EntityFrameworkCore;
using OrganizationManagementTool.Interfaces;
using OrganizationManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Repositories
{
    public class OrganizationManagementRepository : IOrganizationManagement
    {
        private readonly OrganizationManagementContext _Db;
        public OrganizationManagementRepository(OrganizationManagementContext Db)
        {
            _Db = Db;
        }

        public List<FacultyModel> GetAllFacultyList()
        {
            var temp = _Db.FacultyTbl.Include(d => d.Department).ToList();
            return temp;
        }

        public List<FacultyModel> GetAllFacultyList(string temp)
        {
            var factlist = from FT in _Db.FacultyTbl
                           join DT in _Db.DepartmentTbl
                           on FT.DeptId equals DT.Id
                           into Dep
                           from DT in Dep.DefaultIfEmpty()

                           select new FacultyModel
                           {
                               Id = FT.Id,
                               Name = FT.Name,
                               Mobile = FT.Mobile,
                               Email = FT.Email,
                               Age = FT.Age,
                               Gender = FT.Gender,
                               DeptId = FT.DeptId,
                               DeptName = DT == null ? "" : DT.DeptName
                           };

            if (!String.IsNullOrEmpty(temp))
            {
                factlist = factlist.Where(x => x.Name.Contains(temp) || x.Mobile.Contains(temp) || x.Email.Contains(temp) || x.Age.ToString().Contains(temp) || x.Gender.Contains(temp) || x.DeptName.Contains(temp));
            }
            return factlist.ToList();
        }

        public async Task AddFaculty(FacultyModel objFact)
        {
            try
            {
                    if (objFact.Id == 0)
                    {
                        _Db.FacultyTbl.Add(objFact);
                        _Db.SaveChanges();
                    }
                    else
                    {
                        _Db.Entry(objFact).State = EntityState.Modified;
                        _Db.SaveChanges();
                    }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task DeleteFaculty(int id)
        {
            try
            {
                //FacultyModel fact1 = _Db.FacultyTbl.Where(a => a.Id == id).SingleOrDefault();
                var fact = _Db.FacultyTbl.Find(id);
                if (fact != null)
                {
                    _Db.FacultyTbl.Remove(fact);
                    _Db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public List<DepartmentsModel> LoadDepartment()
        {
            List<DepartmentsModel> deptList = new List<DepartmentsModel>();
            deptList = _Db.DepartmentTbl.ToList();
            deptList.Insert(0, new DepartmentsModel { Id = 0, DeptName = "Please Select" });
            return deptList;
        }
    }
}
