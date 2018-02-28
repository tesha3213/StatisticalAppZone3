using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ThonController : Controller
    {
        // GET: Thon
        public ActionResult Index()
        {
            List<mvcThonModel> thonList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Thon").Result;
            thonList = response.Content.ReadAsAsync<List<mvcThonModel>>().Result;
            return View(thonList);
        }
    }
}