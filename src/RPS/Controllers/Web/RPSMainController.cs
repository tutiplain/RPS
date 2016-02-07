using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPS.Controllers.Web
{
    public class RPSMainController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        //register player
        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Games()
        {
            return View();
        }

    }
}
