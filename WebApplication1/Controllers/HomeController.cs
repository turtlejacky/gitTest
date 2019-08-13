using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			var a = "this is language";

			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			var a = "this is fix language bug";

			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}