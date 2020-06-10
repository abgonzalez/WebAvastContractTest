using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAvantTest.Models;
using WebAvantTest.Core;
using System;

namespace WebAvantTest.Controllers
{
    public class HomeController : Controller
    {
        public object Ensure { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowTable(int number)
        {
            try
            {
                return PartialView("ShowTable", new MatrixViewModel(new PrimeNumbersTable(FindPrimeNumber.findPrimes(number))));
            }
            catch (Exception e)
            {
                throw new Exception("Error message" + e);
            }
        }

    }
}
