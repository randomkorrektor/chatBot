using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBase;

namespace chatBot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Messages = MemoryManager.GetAllMessages();
            return View();
        }
        public ActionResult Send(string text)
        {
            MemoryManager.AddMessage(text);
            MemoryManager.AddMessage(KeyWordsManager.wordFinder(text));
            ViewBag.Messages = MemoryManager.GetAllMessages();
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}