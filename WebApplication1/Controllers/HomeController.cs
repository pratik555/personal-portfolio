using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.Title = "Pie Overview";
            var pies = _pieRepository.GetAllPies().OrderBy(x => x.Name);
            var homeViweModel = new HomeViewModel()
            {
                Title = "Welcome Bethney Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViweModel);
        }
    }
}
