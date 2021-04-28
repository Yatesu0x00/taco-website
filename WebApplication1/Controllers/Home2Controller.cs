using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home2Controller/test/
        public string Test()
        {
            return "Your are on the same Node tho ( •_•)";
        }
    }
}
