using MyHR.Domain.Models;
using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class SalaryBonusController : Controller
    {
        private readonly SalaryModule _salaryModule;
        // GET: SalaryBonus

        public SalaryBonusController()
        {
            _salaryModule = new SalaryModule();
        }
        public ActionResult Salary()
        {
            return View();
        }

        public JsonResult ServerFiltering_GetEmployees()
        {        
            EmployeeModule employeeModule = new EmployeeModule();
            List<Employee> listEmployee = employeeModule.GetEmployeeCombo();

            return Json(listEmployee, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ServerFiltering_GetCurrency()
        {
            DictionaryItemModule dictionaryModule = new DictionaryItemModule();
            List<DictionaryItem> listCurrenty = dictionaryModule.ListCurrency();

            return Json(listCurrenty, JsonRequestBehavior.AllowGet);
        }

    }
}