using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ODD.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> DoWorkAsync(int duration = 20)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            await Task.Run(()=> CpuIntensiveMulti(duration));

            return RedirectToAction("Index");
        }

        public static string GetIPAddress()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            return ipAddress.ToString();
        }

        void CpuIntensiveMulti(int duration = 10)
        {
            Enumerable
                .Range(1, Environment.ProcessorCount-1) // replace with lesser number if 100% usage is not what you are after.
                .AsParallel()
                .Select(i =>
                {
                    var end = DateTime.Now + TimeSpan.FromSeconds(duration);
                    while (DateTime.Now < end)
                        /*nothing here */
                        ;
                    return i;
                })
                .ToList(); // ToList makes the query execute.
        }

        void CpuIntensive()
        {
            var startDt = DateTime.Now;

            while (true)
            {
                if ((DateTime.Now - startDt).TotalSeconds >= 10)
                    break;
            }

        }
    }
}