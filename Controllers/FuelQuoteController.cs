// ----- IMPORTANT -----
// when creating a new controller the correct sytax is *ControllerName*Controller. IT MUST END WITH Controller as the SUFFIX in order for MVC to invoke the controller

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    
    public class FuelQuoteController : Controller
    {
        private readonly ILogger<FuelQuoteController> _logger;

        public FuelQuoteController(ILogger<FuelQuoteController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult FuelQuoteForm()
        {
            return View();
        }
        public IActionResult FuelQuoteHistory()
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

