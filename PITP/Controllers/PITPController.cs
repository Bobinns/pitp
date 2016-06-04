using PITP;
using PITP.Models;
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

        // The url tent-city is assigned in the RouteConfig Page
        //[ActionName("tent-city")]
        public ActionResult tentcity()
        {
            ViewBag.Description = "Party in the Park 2016 Tent City";
            ViewBag.Keywords = "housing stall, information on social housing, tenant empowerment, stop social cleansing in london Demanding, Housing for Our Community";
            return View();
        }

        [HttpPost]
        //[ActionName("tent-city")]
        public ActionResult tentcity(email mail)
        {
            ViewBag.Description = "Party in the Park 2016 Tent City";
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
            ViewBag.Description = "Party in the Park held its second festival in 2014";
            ViewBag.Keywords = "Party, Park, festval, 2013, New Cross, Deptford";
            return View();
        }

        public ActionResult year2013()
        {
            ViewBag.Description = "Party in the Park held its first festival in 2013";
            ViewBag.Keywords = "Party, Park, festval, 2014, New Cross, Deptford";
            return View();
        }


        public ActionResult Volunteer()
        {
            ViewBag.Description = "Party in the Park volunteers";
            ViewBag.Keywords = "volunteers, help, stewards, promotion, help";
            volunteer vol = new volunteer();

            vol.Over18 = new[]
            {
                "Yes",
                "No"
            };

            vol.InterestedRoles = new[]
            {
                "Assistant Head Steward",
                "Chief Steward",
                "Steward",
                "Crew",
                "Catering Assistant",
                "MADCAP child steward",
                "Parking Steward"
            };

            vol.Skills = new[] {
                "First Aid training",
                "Health and Safety Training",
                "Working with children"
            };

            vol.FirstAid = new[]
            {
                "Yes",
                "No"
            };

            vol.CRB = new []
            {
                "Yes",
                "No"
            };

            vol.MadCap = false;


            return View(vol);
        }

        [HttpPost]
        public ActionResult Volunteer(volunteer vol)
        {
            //email mail = new email();

            
                ViewBag.Description = "Party in the Park volunteers";
                ViewBag.Keywords = "volunteers, help, stewards, promotion, help";
                StringBuilder sb = new StringBuilder();
                sb.Append("<p>A form from the Party in the Park Volunteer page has been sent - </p>");
                sb.Append("<p>Name: " + vol.Name + "</p>");
                sb.Append("<p>Email: " + vol.Email + "</p>");
                sb.Append("<p>Date sent: " + vol.Date + "</p>");
                if (!string.IsNullOrEmpty(vol.Telephone)) sb.Append("<p>Message: " + vol.Telephone + "</p>");

                if (vol.Over18 != null)
                {
                    sb.Append("<p>Over the age of 18 and under 55 years old: ");
                    foreach (string value in vol.Over18)
                    {
                        sb.Append("<br>" + value + " ");
                    }
                    sb.Append("</p>");
                }


                if (vol.InterestedRoles != null)
                {
                    sb.Append("<p>Roles interested in : ");
                    foreach (string value in vol.InterestedRoles)
                    {
                        sb.Append("<br>" + value + " ");
                    }
                    sb.Append("</p>");
                }

                if (vol.Skills != null)
                {
                    sb.Append("<p>Skills: ");
                    foreach (string value in vol.Skills)
                    {
                        sb.Append("<br>" + value + " ");
                    }
                    sb.Append("</p>");
                }

                if (vol.CRB != null)
                {
                    sb.Append("<p>CRB status: ");
                    foreach (string value in vol.CRB)
                    {
                        sb.Append("<br>" + value + " ");
                    }
                    sb.Append("</p>");
                }

            if (vol.FirstAid != null)
                {
                    sb.Append("<p>Want's to take a First Aid course: ");
                    foreach (string value in vol.FirstAid)
                    {
                        sb.Append("<br>" + value + " ");
                    }
                    sb.Append("</p>");
                }


            if (vol.MadCap) sb.Append("<p>Is Interested in helping out with MadCap: " + vol.MadCap + "</p>");
                else sb.Append("<p>Is <b>not</b> Interested in helping out with MadCap: " + vol.MadCap + "</p>");

                SendEmail.SendMail(sb.ToString(), "Potential volunteer request from the PITP Web site ", vol.Email, "vols@pitpnxd.co.uk");
                ViewData["Message"] = "<p>Thank you " + vol.Name + "</p><p>We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team</p>";
                ViewData["Sent"] = "sent";

            return View(vol);
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
