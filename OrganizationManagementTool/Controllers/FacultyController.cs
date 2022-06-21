using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OrganizationManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Controllers
{
    public class FacultyModelController : Controller
    {
        //private readonly FacultyModelContext _Db;
        private readonly OrganizationManagementContext _Db;
        public FacultyModelController(OrganizationManagementContext Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FacultyList()
        {
            try
            {
                var FacultyModelList = _Db.FacultyTbl.Join(_Db.DepartmentTbl, x => x.DeptId, y => y.Id,
                      (x, y) => new FacultyModel
                      {
                          Id = x.Id,
                          Name = x.Name,
                          Mobile = x.Mobile,
                          Email = x.Email,
                          Age = x.Age,
                          Gender = x.Gender,
                          DeptId = x.DeptId,
                          DeptName = y == null ? "" : y.DeptName
                      }
                      );

                //var FacultyModelList = from FT in _Db.FacultyModelTbl
                //                  join DT in _Db.DepartmentTbl
                //                  on FT.DeptId equals DT.Id
                //                  into Dep
                //                  from DT in Dep.DefaultIfEmpty()

                //                  select new FacultyModel
                //                  {
                //                      Id = FT.Id,
                //                      Name = FT.Name,
                //                      Mobile = FT.Mobile,
                //                      Email = FT.Email,
                //                      Age = FT.Age,
                //                      Gender = FT.Gender,
                //                      DeptId = FT.DeptId,
                //                      DeptName = DT == null ? "" : DT.DeptName
                //                  };

                return View(FacultyModelList);
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> FacultyList(string tmp)
        {
            ViewData["GetFacultyModelList"] = tmp;
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

            if (!String.IsNullOrEmpty(tmp))
            {
                factlist = factlist.Where(x => x.Name.Contains(tmp) || x.Mobile.Contains(tmp) || x.Email.Contains(tmp) || x.Age.ToString().Contains(tmp) || x.Gender.Contains(tmp) || x.DeptName.Contains(tmp));
            }
            return View(await factlist.AsNoTracking().ToListAsync());
        }

        public IActionResult FacultyModel(FacultyModel objFact)
        {
            LoadDDL();
            ModelState.Clear();
            return View(objFact);
        }

        [HttpPost]
        public async Task<IActionResult> AddFacultyModel(FacultyModel objFact)
        {
            try
            {
                if (ModelState.IsValid)
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
                    return RedirectToAction("FacultyModelList");
                }
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("FacultyModelList");
            }

        }

        public async Task<IActionResult> DeleteFacultyModel(int id)
        {
            try
            {
                var fact = await _Db.FacultyTbl.FindAsync(id);
                if (fact != null)
                {
                    _Db.FacultyTbl.Remove(fact);
                    await _Db.SaveChangesAsync();
                }
                return RedirectToAction("FacultyModelList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("FacultyModelList");
            }
        }

        private void LoadDDL()
        {
            try
            {
                List<DepartmentsModel> deptList = new List<DepartmentsModel>();
                deptList = _Db.DepartmentTbl.ToList();
                deptList.Insert(0, new DepartmentsModel { Id = 0, DeptName = "Please Select" });


                ViewBag.DeptList = deptList;
            }
            catch
            {

            }
        }


    }
}
