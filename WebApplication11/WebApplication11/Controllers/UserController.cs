using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.DataAccess;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg(string login, string password, string phoneNumber)
        {
            using (var context = new Context())
            {
                if (login != null && password != null && phoneNumber != null)
                {
                    var user = new User
                    {
                        Login = login,
                        Password = password,
                        PhoneNumber = phoneNumber
                    };
                    context.Users.Add(user);
                    context.SaveChanges();

                    return RedirectToAction("AllNews");

                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        public ActionResult Auth()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Auth(string login, string password)
        {
            using (var context = new Context())
            {
                var admin = context.Admins.FirstOrDefault(adm => adm.Login == login && adm.Password == password);
                if (admin != null)
                {
                    return RedirectToAction("AllNews");
                }
                else
                {
                    ViewBag.Message = "Неправильно введены данные, повторите снова";
                    return View();
                }
            }
        }

        public ActionResult AllNews()
        {
            using (var context = new Context())
            {
                ViewBag.News = context.News.ToList();
                return View();
            }
        }
    }
}