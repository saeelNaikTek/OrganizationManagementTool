using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OrganizationManagementTool.Interfaces;
using OrganizationManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Controllers
{
    public class FacultyController : Controller
    {
        //private readonly FacultyModelContext _Db;
        private readonly OrganizationManagementContext _Db;
        private readonly IOrganizationManagement _obj;
        public FacultyController(OrganizationManagementContext Db, IOrganizationManagement obj)
        {
            _Db = Db;
            _obj = obj;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FacultyList()
        {
            try
            {
               var test = _obj.GetAllFacultyList();
               var temp =  _Db.FacultyTbl.Include(d => d.Department).ToList();

                //var FacultyModelList = _Db.FacultyTbl.Join(_Db.DepartmentTbl, x => x.DeptId, y => y.Id,
                //      (x, y) => new FacultyModel
                //      {
                //          Id = x.Id,
                //          Name = x.Name,
                //          Mobile = x.Mobile,
                //          Email = x.Email,
                //          Age = x.Age,
                //          Gender = x.Gender,
                //          DeptId = x.DeptId,
                //          DeptName = y == null ? "" : y.DeptName
                //      }
                //      );

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

                //return View(FacultyModelList);
                return View(test);
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> FacultyList(string tmp)
        {
            var test = _obj.GetAllFacultyList(tmp);
            ViewData["GetFacultyList"] = tmp;
            //var factlist = from FT in _Db.FacultyTbl
            //               join DT in _Db.DepartmentTbl
            //               on FT.DeptId equals DT.Id
            //               into Dep
            //               from DT in Dep.DefaultIfEmpty()

            //               select new FacultyModel
            //               {
            //                   Id = FT.Id,
            //                   Name = FT.Name,
            //                   Mobile = FT.Mobile,
            //                   Email = FT.Email,
            //                   Age = FT.Age,
            //                   Gender = FT.Gender,
            //                   DeptId = FT.DeptId,
            //                   DeptName = DT == null ? "" : DT.DeptName
            //               };

            //if (!String.IsNullOrEmpty(tmp))
            //{
            //    factlist = factlist.Where(x => x.Name.Contains(tmp) || x.Mobile.Contains(tmp) || x.Email.Contains(tmp) || x.Age.ToString().Contains(tmp) || x.Gender.Contains(tmp) || x.DeptName.Contains(tmp));
            //}
            return View(test);
            //return View(await factlist.AsNoTracking().ToListAsync());
        }

        public IActionResult Faculty(FacultyModel objFact)
        {
            LoadDDL();
            ModelState.Clear();
            return View(objFact);
        }

        [HttpPost]
        public async Task<IActionResult> AddFaculty(FacultyModel objFact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   var query = _obj.AddFaculty(objFact);
                    //if (objFact.Id == 0)
                    //{
                    //    _Db.FacultyTbl.Add(objFact);
                    //    await _Db.SaveChangesAsync();
                    //}
                    //else
                    //{
                    //    _Db.Entry(objFact).State = EntityState.Modified;
                    //    await _Db.SaveChangesAsync();
                    //}
                    return RedirectToAction("FacultyList");
                }
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("FacultyList");
            }

        }

        public async Task<IActionResult> DeleteFaculty(int id)
        {
            try
            {
                var query = _obj.DeleteFaculty(id);
                //var fact = await _Db.FacultyTbl.FindAsync(id);
                //if (fact != null)
                //{
                //    _Db.FacultyTbl.Remove(fact);
                //    await _Db.SaveChangesAsync();
                //}
                return RedirectToAction("FacultyList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("FacultyList");
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
