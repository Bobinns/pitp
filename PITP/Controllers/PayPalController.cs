using PITP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PITP.Controllers
{
    public class PayPalController : Controller
    {
        public ActionResult thankyou()
        {
            ViewBag.Message1 = "Thank you very much - Party in the Park very much appreciates your donation";
            
            return View();
        }
    }
}
