using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CKeditor.Controllers
{
    public class HomeController : Controller
    {

      
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index()
        //{
        //    ViewBag.picture = Picture;
        //    ViewBag.detail = Detail;
        //    return View("Detail");
        //}

        [HttpPost]
        [ValidateInput(false)]
        public  ActionResult Detail(string Picture, string Detail)
        {
            ViewBag.picture = Picture;
            ViewBag.detail = Detail;
            return View();

        }
    }
}