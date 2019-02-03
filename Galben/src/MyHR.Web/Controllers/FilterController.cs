
using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class FilterController : Controller
    {
        
        
        // GET: Filter
        public ActionResult Index()
        {
            return View();
        }

        /*public JsonResult AutoCompleteDepartment(string text)
        {
            var deparment = new DictionaryItemModule();
            var deparment2 = deparment.ListDepartment.ToString();
        }*/
    }
}