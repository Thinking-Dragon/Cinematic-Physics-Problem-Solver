using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Cinematic_Physics_Problem_Solver.Controllers
{
    public class SolverController : Controller
    {
        public IActionResult Index() => RedirectToAction("Index", "Home");

        public IActionResult Solve()
        {
            if (HttpContext.Request.Method != "POST") RedirectToAction("Index", "Home");
            return View();
        }
    }
}