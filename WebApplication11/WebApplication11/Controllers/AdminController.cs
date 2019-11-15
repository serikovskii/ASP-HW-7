using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.DataAccess;

namespace WebApplication11.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            using (var context = new Context())
            {
                var admin = context.Admins.FirstOrDefault(adm => adm.Login == login && adm.Password == password);
                if (admin != null)
                {
                    return RedirectToAction("Index", "News");
                }
                else { 
                    ViewBag.Message = "Неправильно введены данные, повторите снова";
                    return View();
                }
            }
        }
    }
}