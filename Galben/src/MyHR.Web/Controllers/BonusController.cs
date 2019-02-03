using MyHR.Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class BonusController : Controller
    {
        private readonly BonusModule _bonusModule;
        
        // GET: Bonus
        public ActionResult Index()
        {
            return View();
        }
        
        public BonusController()
        {
            _bonusModule = new BonusModule();
        }
        /*
        public ActionResult GetBonuses()
        {

            return View(_bonusModule.GetBonuses());
        }
        */
        

    }
}