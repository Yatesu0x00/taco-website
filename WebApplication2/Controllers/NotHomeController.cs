using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace WebApplication2.Controllers
{
    public class NotHomeController : Controller
    {
        private Random rnd;

        public IActionResult Index()
        {
            return View();
        }

        // GET: /NotHomeController/test/
        public string Test()
        {
            rnd = new Random();
            while (true)
            {
                int timeToWait = rnd.Next(1, 5);
                
                while (true)
                {
                    Thread.Sleep(timeToWait * 1000); //wait between 1 and 5 sek
                    return "Nice! IT WOOOOORKS! ＼(^o^)／";
                }
            }

        }
    }
}
