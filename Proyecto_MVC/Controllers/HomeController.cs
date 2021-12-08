using Proyecto_MVC.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using Proyecto_MVC.ProxyVuelos;

namespace Proyecto_MVC.Controllers
{
    public class HomeController : Controller
    {

        private ServicioVueloClient miservVuelos = new ServicioVueloClient();

        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();

            mymodel.Departamentos = miservVuelos.ListarDepartamentos();
            mymodel.Vuelos = miservVuelos.GetAllVuelos ();

            return View(mymodel);
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
        public ActionResult Mantenimiento()
        {
            ViewBag.Message = "Mantenimiento de tablas";

            return View();
        }
    }
}