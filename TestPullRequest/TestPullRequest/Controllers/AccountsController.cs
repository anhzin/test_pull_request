using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPullRequest.Controllers
{
	public class AccountsController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Account Page GC 0005 develop";

			return View();
		}
	}
}
