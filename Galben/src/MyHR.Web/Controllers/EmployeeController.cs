using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MyHR.Domain.Models;
using MyHR.Domain.Modules;

namespace MyHR.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeModule _employeeModule; //instanta folosita in ActionResult
        private readonly DictionaryItemModule _dictionaryItemModule;

        public EmployeeController()
        {
            _employeeModule = new EmployeeModule();
            _dictionaryItemModule = new DictionaryItemModule();
        }


        [HttpGet]
        public ActionResult GetEmployees()
        {
            MyHR.Domain.Models.Filter filter = new MyHR.Domain.Models.Filter();
            return View();
        }

        public ActionResult GetEmployeesData([DataSourceRequest]DataSourceRequest request, string Name, int IdDepartment)

        {
            List<Employee> emplist;
            if (String.IsNullOrEmpty(Name))
            {
                Name = null;
            }

            emplist = _employeeModule.GetEmployees(request.Page, request.PageSize, Name, IdDepartment);
            int numberOfEmployees = _employeeModule.GetNumberOfEmployees(Name, IdDepartment);
            var result = new DataSourceResult()
            {
                Data = emplist,
                Total = numberOfEmployees
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public ActionResult AddEmployee(int? employeeeId)  // nu stiu de ce a pus Alex parametru (int employeeeId)
        {
            if (employeeeId != 0)
            {
                //get din db
                NewEmployeeModel employee = new NewEmployeeModel();
                return View(employee);
            }
            else
            {
                NewEmployeeModel employee = new NewEmployeeModel();
                return View(employee);
            }
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeEditModel employeeEditModel)
        {
            if (ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                errors = _employeeModule.SaveEmployee(employeeEditModel);

                if (errors.Any())
                {
                    foreach (string error in errors)
                        ModelState.AddModelError(Guid.NewGuid().ToString(), error);

                    return View("AddEmployee", employeeEditModel);
                }
                else
                {
                    return RedirectToAction("GetEmployees", "Employee");
                }
            }
            return View("AddEmployee", employeeEditModel);
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}


    }
}