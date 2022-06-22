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

        public async Task<int> AddFaculty(FacultyModel objFact)
        {
            try
            {
                    if (objFact.Id == 0)
                    {
                        _Db.FacultyTbl.Add(objFact);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(objFact).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }
                    return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task DeleteFaculty(int id)
        {
            try
            {
                var fact = await _Db.FacultyTbl.FindAsync(id);
                if (fact != null)
                {
                    _Db.FacultyTbl.Remove(fact);
                    await _Db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
