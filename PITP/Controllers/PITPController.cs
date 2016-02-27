using PITP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PITP
{
    public class PITPController : Controller
    {
        //
        // GET: /PITP/

        public ActionResult Index()
        {
            ViewBag.Description = "Party in the Park is a community event for all ages held in Fordham Park Deptford";
            ViewBag.Keywords = "Party, park, Deptford, New Cross, Lewisham, community, event, pop, rock, folk, festival";
            return View();
        }

        [ActionName("about-us")]
        public ActionResult AboutUs()
        {
            ViewBag.Description = "Party in the Park is community event held anually in Fordham Park Deptford";
            ViewBag.Keywords = "Party, park, community, all ages, family event, New Cross, Deptford, festival";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Description = "If you want to contact party in the park use this form";
            ViewBag.Keywords = "Contact, email, get in touch, Party, park, question?, help";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(email mail)
        {
            ViewBag.Description = "If you want to contact party in the park use this form";
            ViewBag.Keywords = "Contact, email, get in touch, Party, park, question?, help";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>A form from the Party in the Park Contact page has been sent - </p>");
            sb.Append("<p>Email: " + mail.Email + "</p>");
            sb.Append("<p>Message: " + mail.Message + "</p>");


            SendEmail.SendMail(sb.ToString(), "A contact request from the PITP Web site ", mail.Email, "pitpnxd@gmail.com");
            ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
            ViewData["Sent"] = "sent";
            return View();
        }

        public ActionResult Origins()
        {
            ViewBag.Description = "Party in the Park orginated from the urban free festival - 'you can't kill the spirit";
            ViewBag.Keywords = "Party, Park, urban, free, festival";
            return View();
        }
       
        public ActionResult Party2013()
        {
            ViewBag.Description = "Party in the Park held its first festival in 2013";
            ViewBag.Keywords = "Party, Park, festval, 2013, New Cross, Deptford";
            return View();
        }



        public ActionResult Upandcoming()
        {
            ViewBag.Description = "Up and coming Party in the Park events and fund raisers";
            ViewBag.Keywords = "Party, festival, event, fund raiser, SKA-BQ";
            return View();
        }

        public ActionResult sponsors()
        {
            ViewBag.Description = "Party in the Park Sponsors and sponsorship";
            ViewBag.Keywords = "Party, Park, sponsors, sponsorship, funding, help";
            email mail = new email();
            mail.Subject = "web site email sent from the sponsors page";
            
            return View(mail);
        }

        public ActionResult pastevents()
        {
            ViewBag.Description = "Party in the Park Sponsors and past events";
            ViewBag.Keywords = "Party, Park, sponsors, sponsorship, funding, help, past events";
            return View();
        }

        [HttpPost]
        public ActionResult sponsors(email mail)
        {
            ViewBag.Description = "Party in the Park Sponsors and sponsorship";
            ViewBag.Keywords = "Party, Park, sponsors, sponsorship, funding, help";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>A form from the Party in the Park Sponsorship page has been sent - </p>");
            sb.Append("<p>Email: " + mail.Email + "</p>");
            sb.Append("<p>Message: " + mail.Message + "</p>");


            SendEmail.SendMail(sb.ToString(), "Potential sponsorship request from the PITP Web site ", mail.Email, "pitpnxd@gmail.com");
            ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
            ViewData["Sent"] = "sent";
            return View();
        }


        public ActionResult Volunteer()
        {
            ViewBag.Description = "Party in the Park volunteers";
            ViewBag.Keywords = "volunteers, help, stewards, promotion, help";
            return View();
        }

        [ActionName("tent-city")]
        public ActionResult housinginfoarea()
        {
            ViewBag.Description = "Party in the Park housing information Area";
            ViewBag.Keywords = "housing stall, information on social housing, tenant empowerment, stop social cleansing in london";
            return View();
        }

        [HttpPost]
        [ActionName("tent-city")]
        public ActionResult housinginfoarea(email mail)
        {
            ViewBag.Description = "Party in the Park Tent City";
            ViewBag.Keywords = "housing stall, information on social housing, tenant empowerment, stop social cleansing in london";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>A form from the Party in the Park Housing Area Info page has been sent - </p>");
            sb.Append("<p>Email: " + mail.Email + "</p>");
            sb.Append("<p>Message: " + mail.Message + "</p>");


            SendEmail.SendMail(sb.ToString(), "Housing Area Info request from the PITP Web site ", mail.Email, "housing@pitpnxd.co.uk");
            ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
            ViewData["Sent"] = "sent";
            return View();
        }

        public ActionResult year2014()
        {
            ViewBag.Description = "Party in the Park held its first festival in 2014";
            ViewBag.Keywords = "Party, Park, festval, 2014, New Cross, Deptford";
            return View();
        }

        [HttpPost]
        public ActionResult Volunteer(email mail)
        {
            ViewBag.Description = "Party in the Park volunteers";
            ViewBag.Keywords = "volunteers, help, stewards, promotion, help";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>A form from the Party in the Park Volunteer page has been sent - </p>");
            sb.Append("<p>Email: " + mail.Email + "</p>");
            sb.Append("<p>Message: " + mail.Message + "</p>");


            SendEmail.SendMail(sb.ToString(), "Potential volunteer request from the PITP Web site ", mail.Email, "vols@pitpnxd.co.uk");
            ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
            ViewData["Sent"] = "sent";
            return View();
        }

        public ActionResult SiteMap()
        {
            ViewBag.Description = "Party in the Park sitemap";
            ViewBag.Keywords = "Party, Park, sitemap";
            ViewBag.Message = "A map of our site";
            return View();
        }


    }
}
