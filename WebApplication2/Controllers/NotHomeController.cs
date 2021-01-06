using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class NotHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /NotHomeController/test/
        public string Test()
        {
            return "IT WOOOOORKS! ＼(^o^)／";
        }
    }
}
