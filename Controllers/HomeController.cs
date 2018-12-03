using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisScheduleMvc.Models;

namespace TennisScheduleMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TennisSchedule()
        {
            ViewBag.Message = "Your application description page.";
            TennisScheduleModel tennis = new TennisScheduleModel();
            tennis.ReadXml();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}