﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OrganizationManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationManagementTool.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyContext _Db;
        public FacultyController(FacultyContext Db)
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
                var FacultyList = _Db.Faculty_Tbl.Join(_Db.Department_Tbl,x=>x.DeptId, y => y.Id,
                      (x, y) => new Faculty
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

                //var FacultyList = from FT in _Db.Faculty_Tbl
                //                  join DT in _Db.Department_Tbl
                //                  on FT.DeptId equals DT.Id
                //                  into Dep
                //                  from DT in Dep.DefaultIfEmpty()

                //                  select new Faculty
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

                return View(FacultyList);
            }
            catch
            {
                return View();
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> FacultyList(string tmp)
        {
            ViewData["GetFacultyList"] = tmp;
            var factlist = from FT in _Db.Faculty_Tbl
                           join DT in _Db.Department_Tbl
                           on FT.DeptId equals DT.Id
                           into Dep
                           from DT in Dep.DefaultIfEmpty()

                           select new Faculty
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

        public IActionResult Faculty(Faculty objFact)
        {
            LoadDDL();
            ModelState.Clear();
            return View(objFact);
        }

        [HttpPost]
        public async Task<IActionResult> AddFaculty(Faculty objFact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(objFact.Id == 0)
                    {
                        _Db.Faculty_Tbl.Add(objFact);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(objFact).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }
                    return RedirectToAction("FacultyList");
                }
                return View();
            }
            catch(Exception ex)
            {
                return RedirectToAction("FacultyList");
            }
            
        }

        public async Task<IActionResult> DeleteFaculty(int id)
        {
            try
            {
                var fact = await _Db.Faculty_Tbl.FindAsync(id);
                if(fact != null)
                {
                    _Db.Faculty_Tbl.Remove(fact);
                    await _Db.SaveChangesAsync();
                }
                return RedirectToAction("FacultyList");
            }
            catch(Exception ex)
            {
                return RedirectToAction("FacultyList");
            }
        }

        private void LoadDDL()
        {
            try
            {
                List<Departments> deptList = new List<Departments>();
                deptList = _Db.Department_Tbl.ToList();
                deptList.Insert(0, new Departments { Id = 0, DeptName = "Please Select" });


                ViewBag.DeptList = deptList;
            }
            catch
            {

            }
        }


    }
}
