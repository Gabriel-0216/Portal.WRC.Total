using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.WRC.Total.com.Controllers
{
    public class AboutWRCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
