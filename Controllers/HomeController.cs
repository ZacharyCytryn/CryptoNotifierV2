using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CryptoNotification.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CryptoNotification.Services;

namespace CryptoNotification.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //private DbContext db;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        public IActionResult Notifier()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Notifier(NotifierModel model)
        {

            string email = model.Email;
            decimal price = model.Price;
            string direction = model.Direction;
            string crypto = model.Crypto;

            return View(model);
        }

        [Authorize]
        public IActionResult Buyer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buyer(BuyerModel model)
        {
            string buyerEmail = model.BuyerEmail;
            decimal buyerCost = model.BuyerCost;
            string cryptocurrency = model.Cryptocurrency;
        }
    }
}
