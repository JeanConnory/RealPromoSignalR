using Microsoft.AspNetCore.Mvc;
using RealPromo.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Promocao()
        {
            return View();
        }

        public ActionResult CadastrarPromocao()
        {
            return View();
        }

    }
}
