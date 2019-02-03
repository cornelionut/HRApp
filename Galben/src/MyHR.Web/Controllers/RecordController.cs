using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class RecordController : Controller
    {
        private readonly RecordModule _recordModule;


        public RecordController()
        {
            _recordModule = new RecordModule();
        }

        public ActionResult GetEmployeeRecord(int id)
        {
            return View();
        }
    }
}