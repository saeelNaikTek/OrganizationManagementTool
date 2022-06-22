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
        private readonly IOrganizationManagement _Db;
        public FacultyController(IOrganizationManagement Db)
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
               var factList = _Db.GetAllFacultyList();
               return View(factList);
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> FacultyList(string tmp)
        {
            var factList = _Db.GetAllFacultyList(tmp);
            ViewData["GetFacultyList"] = tmp;
            return View(factList);
        }

        public IActionResult Faculty(FacultyModel objFact)
        {
            var temp = _Db.LoadDepartment();
            ViewBag.DeptList = temp;
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
                   var query = _Db.AddFaculty(objFact);
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
                var query = _Db.DeleteFaculty(id);
                return RedirectToAction("FacultyList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("FacultyList");
            }
        }

        //private void LoadDDL()
        //{
        //    try
        //    {
        //        List<DepartmentsModel> deptList = new List<DepartmentsModel>();
        //        deptList = _Db.DepartmentTbl.ToList();
        //        deptList.Insert(0, new DepartmentsModel { Id = 0, DeptName = "Please Select" });
        //        ViewBag.DeptList = deptList;
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
