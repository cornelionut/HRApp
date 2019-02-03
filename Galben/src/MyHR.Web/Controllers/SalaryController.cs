using MyHR.Domain.Models;
using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class SalaryController : Controller
    {
        private readonly SalaryModule _salaryModule;
      
       
        public SalaryController ()
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

        [HttpPost]
        public ActionResult Salary(BonusXSalary salary, bool isBonus,string submit)
        {
            
            if (submit == "Salvare/Nou") {
                if (isBonus == false)
                {
                    _salaryModule.ModuleInsertSalary(salary.IdEmployee, salary.StartDate, salary.Amount, salary.IdCurrency);
                }
                else if (isBonus == true)
                {
                    _salaryModule.ModuleInsertBonus(salary.IdEmployee, salary.StartDate, salary.Amount, salary.IdCurrency);
                }
                
            }
            else if (submit == "Salvare")
            {
                if (isBonus == false)
                {
                    _salaryModule.ModuleInsertSalary(salary.IdEmployee, salary.StartDate, salary.Amount, salary.IdCurrency);
                }
                else if (isBonus == true)
                {
                    _salaryModule.ModuleInsertBonus(salary.IdEmployee, salary.StartDate, salary.Amount, salary.IdCurrency);
                }
                return RedirectToAction("GetEmployees", "Employee");
            }

            if(submit=="Anulare")
                return RedirectToAction("GetEmployees", "Employee");
           
            return View(salary);
        }

    }
}