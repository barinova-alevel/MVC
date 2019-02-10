using MVCNext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SquareLogic;

namespace MVCNext.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(new SquareModel());
        }

        [HttpPost]
        public ActionResult About(SquareModel model)
        {
            Decider decide = new Decider();
            model.Result = decide.Decide(model.A, model.B, model.C);
            if(!model.Result.Any())
                ViewBag.Message = "No any roots";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}