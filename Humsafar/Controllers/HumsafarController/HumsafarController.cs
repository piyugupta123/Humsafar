using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Humsafar.Models;

namespace Humsafar.Controllers.HumsafarController
{
    public class HumsafarController : Controller
    {
        // GET: Humsafar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveHumsafar(HumsafarModel model)
        {
            try
            {
                return Json(new { message = (new HumsafarModel().SaveHumsafar(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetHumsafar()
        {
            try
            {
                return Json(new { model = (new HumsafarModel().GetHumsafar()) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}