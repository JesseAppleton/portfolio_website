using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        // Don't really need a database at this time.
        // private DBContext context;

        public IActionResult Index()
        {
            return View();
        }
    }
}
