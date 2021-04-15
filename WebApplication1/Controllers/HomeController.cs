using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private Random rnd;

        // GET: /HomeController/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HomeController/testsamenode/
        public async Task <string> TestSameNode()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://172.29.213.18:32000/nothome/test"; //localhost:44344

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    
                    while (true)
                    {
                        rnd = new Random();

                        int timeToWait = rnd.Next(1, 60);
                        Thread.Sleep(timeToWait * 1000);

                        Console.WriteLine(data);

                        return data;
                    }
                }
                return "error";
            }
        }

        // GET: /HomeController/testanothernode/
        public async Task<string> TestAnotherNode()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://172.29.213.18:32001/nothome/test"; //localhost:44344
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                 
                    while (true)
                    {
                        rnd = new Random();

                        int timeToWait = rnd.Next(1, 60);
                        Thread.Sleep(timeToWait * 1000);

                        Console.WriteLine(data);

                        return data;
                    }
                }
                return "error";
            }
        }

        //Parameter angabe in die URL
        // GET: /Home/ItWorks/?looptimes=...
        // Requires using System.Text.Encodings.Web;
        public IActionResult ItWorks(string message = "You are pretty cool! ( •_•)>⌐■-■", int loopTimes = 2)
        {
            ViewData["Message"] = message;
            ViewData["LoopTimes"] = loopTimes;
            
            if(loopTimes > 100) 
            {
                ViewData["LoopTimes"] = 1;
                ViewData["Message"] = "Oh you try to loop it over 100 times huh?";
            }

            return View();
        }
    }
}
