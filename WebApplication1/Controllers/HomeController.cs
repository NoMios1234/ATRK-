using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        InitContext initContext = new InitContext();
        public ActionResult Index()
        {
            IEnumerable<Song> songs = initContext.Songs;
            IEnumerable<Sound> sounds = initContext.Sounds;
            IEnumerable<Settings> settings = initContext.Settings;

            ViewBag.Songs = songs;
            ViewBag.Sounds = sounds;
            ViewBag.Settings = settings;
            return View();
        }

        
    }
}