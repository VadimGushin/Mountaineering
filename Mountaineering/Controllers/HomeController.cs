using Mountaineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mountaineering.Controllers
{
    public class HomeController : Controller
    {
        DbContext db = new DbContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Article> articles = db.Articles;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Articles = articles;
            // возвращаем представление
            return View();
        }

    }
}
