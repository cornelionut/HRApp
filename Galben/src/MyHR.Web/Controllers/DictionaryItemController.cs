using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyHR.Domain.Models;
using MyHR.Domain.Modules;

namespace MyHR.Web.Controllers
{
    public class DictionaryItemController : Controller
    {
        private readonly DictionaryItemModule _dictionaryItemModule;

        // GET: DictionaryDep by *** Cornel ***
        public ActionResult GetDictionaryDepartment()   // denumirea metodei o sa fie ceva in genul getIstoricFunctii
        {
            return View();
        }

        public DictionaryItemController()
        {
            _dictionaryItemModule = new DictionaryItemModule();
        }

        public ActionResult GetPosition()
        {
            List<DictionaryItem> cityList = _dictionaryItemModule.ListPosition();
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDepartments(string department)
        {
            List<DictionaryItem> cityList = _dictionaryItemModule.ListDepartment();
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetState()
        {
            List<DictionaryItem> cityList = _dictionaryItemModule.ListState();
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDepartament()
        {
            List<DictionaryItem> cityList = _dictionaryItemModule.ListDepartment();
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCurrency()
        {
            return View(_dictionaryItemModule.ListCurrency());
        }

        public ActionResult GetCity(int countyId)
        {
            List<DictionaryItem> cityList = _dictionaryItemModule.ListCity(countyId);
            return Json(cityList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetCounty()
        {
            List<DictionaryItem> countyList = _dictionaryItemModule.ListCounty();
            return Json(countyList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AutoCompleteDepartment(string term)
        {
            var result = (from r in _dictionaryItemModule.ListDepartment()
                              where r.Name.ToLower().Contains(term.ToLower())
                               select new { r.Name }).Distinct();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDepartment(int departmentId)
        {
            _dictionaryItemModule.GetDepartment(departmentId);
            return View();
        }

        public ActionResult GetManager()
        {
            List<DictionaryItem> countyList = _dictionaryItemModule.ListManager();
            return Json(countyList, JsonRequestBehavior.AllowGet);
        }

    }
}