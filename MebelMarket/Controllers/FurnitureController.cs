using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MebelMarket.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
