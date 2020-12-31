using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        // GET: /HomeController/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HomeController/test/
        public string Test() 
        {
            return "test action";
        }

        //Parameter angabe in die URL
        // GET: /Home/Welcome/{ID}/name=.../alter=...
        // Requires using System.Text.Encodings.Web;
        public IActionResult ItWorks(string message = "IT WOOOOORKS! ＼(^o^)／", int loopTimes = 2)
        {
            //return HtmlEncoder.Default.Encode($"Name: {name}, Age: {alter}, ID: {ID}");
            ViewData["Message"] = message;
            ViewData["LoopTimes"] = loopTimes;
            
            if(loopTimes >= 100) 
            {
                ViewData["LoopTimes"] = 1;
                ViewData["Message"] = "Oh you try to loop it over 100 times huh? You are pretty cool! ( •_•)>⌐■-■";
            }

            return View();
        }
    }
}
