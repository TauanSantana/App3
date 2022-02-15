using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace App3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public async Task<string> Sucesso()
        {
            Thread.Sleep(new Random().Next(600, 2000));
            return "";
        }

        [HttpPost]
        public async Task Problema()
        {
            int rnd = new Random().Next(1, 20);
#if !DEBUG
            if (rnd % 3 == 0)
                throw new Exception("Erro fake - Falha ao conectar ao banco de dados");
#endif
            Thread.Sleep(new Random().Next(600, 2000));
        }
    }
}