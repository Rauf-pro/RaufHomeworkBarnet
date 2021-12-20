using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskLesson.DATA;


namespace TaskLesson.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
      
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }

        
    
}
