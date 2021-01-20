using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    public class MaybeHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Test()
        {
            return "IT WOOOOORKS! ＼(^o^)／ but this one is inside of the MaybeController";
        }
    }
}
