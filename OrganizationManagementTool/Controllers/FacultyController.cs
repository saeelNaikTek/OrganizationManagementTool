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
        private readonly OrganizationManagementContext _modelDb;
        public FacultyController(IOrganizationManagement Db, OrganizationManagementContext modelDb)
        {
            _Db = Db;
            _modelDb = modelDb;
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
            catch(Exception ex)
            {
                return View();
            }

        }

        [HttpPost]
        public IActionResult FacultyList(string tmp)
        {
            var factList = _Db.GetAllFacultyList(tmp);
            ViewData["GetFacultyList"] = tmp;
            //return PartialView("_FacultyList", factList);
            return View(factList);
        }

        //public IActionResult Faculty(FacultyModel objFact)
        //{
        //    var temp = _Db.LoadDepartment();
        //    ViewBag.DeptList = temp;
        //    ModelState.Clear();
        //    return View(objFact);
        //}

        public IActionResult Faculty(int id)
        {
            ModelState.Clear();
            var temp = _Db.LoadDepartment();
            ViewBag.DeptList = temp;
            if(id == 0)
            {
                return View();
            }
            else
            {
                var query = _Db.EditFaculty(id);
                return View(query);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddFaculty(FacultyModel objFact)
        {
            try
            {
                //if (ModelState.IsValid)
               // {
                   var query = _Db.AddFaculty(objFact);
                   return RedirectToAction("FacultyList");
              //  }
               // return View();
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

        //Ajax Call
        public JsonResult GetAllFacultyList()//working
        {
            var factList = _Db.GetAllFacultyList();
            return Json(factList);
        }

        public JsonResult GetFacultyList(string tmp)
        {
            var factList = _Db.GetAllFacultyList(tmp);
            ViewData["GetFacultyList"] = tmp;
            return Json(factList);
        }

        //public JsonResult EditFaculty(int id)
        //{
        //    try
        //    {
        //        var query = _Db.EditFaculty(id);
        //        return Json(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(ex);
        //    }
        //}

        public JsonResult DeleteFacultyDtls(int id)
        {
            try
            {
                var query = _Db.DeleteFaculty(id);
                return Json(query);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        //EOC

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
