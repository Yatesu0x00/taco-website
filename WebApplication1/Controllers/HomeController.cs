using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        NotHomeController notHome;

        // GET: /HomeController/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HomeController/test/
        public string Test()
        {
            //return "test action";

            notHome = new NotHomeController();
            return notHome.Test();
        }

        // GET: /HomeController/test2/
        public ActionResult test2() 
        {
            return RedirectToAction("test", "NotHome"); //Redirect function
        }     

        // GET: /HomeController/test3/
        public async Task <string> test3()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:65486/nothome/test";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    //string test = await response.Content.ReadAsAsync<string>();
                    string data = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(data);
                    return data;
                }
                return "error";
                //    return Ok(data);
                //}
                //else 
                //{
                //    return NotFound();
                //}
            }
        }

        //Parameter angabe in die URL
        // GET: /Home/Welcome/{ID}/name=.../alter=...
        // Requires using System.Text.Encodings.Web;
        public IActionResult ItWorks(string message = "You are pretty cool! ( •_•)>⌐■-■", int loopTimes = 2)
        {
            //return HtmlEncoder.Default.Encode($"Name: {name}, Age: {alter}, ID: {ID}");
            ViewData["Message"] = message;
            ViewData["LoopTimes"] = loopTimes;
            
            if(loopTimes >= 100) 
            {
                ViewData["LoopTimes"] = 1;
                ViewData["Message"] = "Oh you try to loop it over 100 times huh?";
            }

            return View();
        }
    }
}
