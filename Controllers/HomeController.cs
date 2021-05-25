using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, UnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var course = _unitOfWork.Courses.Get(1);
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
