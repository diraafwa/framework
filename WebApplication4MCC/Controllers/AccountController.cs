using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4MCC.ViewModels;

namespace WebApplication4MCC.Controllers
{
    HttpClient 
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {

        }
    }
}
