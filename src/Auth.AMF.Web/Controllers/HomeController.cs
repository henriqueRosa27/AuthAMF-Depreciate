using Auth.AMF.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace Auth.AMF.Web.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet("{authHash?:Guid}")]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
