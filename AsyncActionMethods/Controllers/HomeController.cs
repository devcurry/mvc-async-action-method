using AsyncActionMethods.Models;
using StackExchange.Profiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace AsyncActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var profiler = MiniProfiler.Current;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            HttpClient client = new HttpClient();
            var blogs = client.GetStringAsync(new Uri("http://localhost:51601/api/Blogs"));
            ViewBag.Blogs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Blog>>(blogs.Result);
            var favorites = client.GetStringAsync(new Uri("http://localhost:51601/api/Favorites"));
            ViewBag.Blogs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Blog>>(favorites.Result);
            return View();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
