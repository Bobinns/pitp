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
       
        private ppaluserContext pc = new ppaluserContext();

        decimal raisersTodate = 864;
        decimal grandTotal = 7430;

        public ActionResult Index()
        {
            ViewBag.Description = "Party in the Park is a community event for all ages held in Fordham Park Deptford";
            ViewBag.Keywords = "Party, park, Deptford, New Cross, Lewisham, community, event, pop, rock, folk, festival";

            var netTotal = (from d in pc.formusers
                            where d.ppal.paid == true
                            select d.ppal.sAmountPaid
                            ).Sum();

            var amountNeeded = grandTotal - netTotal;
            amountNeeded = amountNeeded - raisersTodate;


            ViewBag.GrandTotal = string.Format("{0:C}", grandTotal);
            ViewBag.AmountNeeded = string.Format("{0:C}", amountNeeded);
            return View();
        }

        [ActionName("about-us")]
        public ActionResult AboutUs()
        {
            ViewBag.Description = "Party in the Park is community event held anually in Fordham Park Deptford";
            ViewBag.Keywords = "Party, park, community, all ages, family event, New Cross, Deptford, festival";

            //var netTotal = (from c in db.Funders
            //                select c.sAmountPaid
            //               ).Sum();
            var netTotal = (from d in pc.formusers
                            where d.ppal.paid == true
                            select d.ppal.sAmountPaid).Sum();

            var amountNeeded = grandTotal - netTotal;
            amountNeeded = amountNeeded - raisersTodate;


            ViewBag.GrandTotal = string.Format("{0:C}", grandTotal);
            ViewBag.AmountNeeded = string.Format("{0:C}", amountNeeded);
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
            //email mail = new email();
            //mail.Subject = "web site email sent from the sponsors page";

            //return View(mail);
            return View();
        }

        public ActionResult pastevents()
        {
            ViewBag.Description = "Party in the Park Sponsors and past events";
            ViewBag.Keywords = "Party, Park, sponsors, sponsorship, funding, help, past events";
            return View();
        }

        //[HttpPost]
        //public ActionResult sponsors(email mail)
        //{
        //    ViewBag.Description = "Party in the Park Sponsors and sponsorship";
        //    ViewBag.Keywords = "Party, Park, sponsors, sponsorship, funding, help";
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("<p>A form from the Party in the Park Sponsorship page has been sent - </p>");
        //    sb.Append("<p>Email: " + mail.Email + "</p>");
        //    sb.Append("<p>Message: " + mail.Message + "</p>");


        //    SendEmail.SendMail(sb.ToString(), "Potential sponsorship request from the PITP Web site ", mail.Email, "pitpnxd@gmail.com");
        //    ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
        //    ViewData["Sent"] = "sent";
        //    return View();
        //}

        // The url tent-city is assigned in the RouteConfig Page
        //[ActionName("tent-city")]
        public ActionResult tentcity()
        {
            ViewBag.Description = "Party in the Park 2018 Tent City";
            ViewBag.Keywords = "housing stall, information on social housing, tenant empowerment, stop social cleansing in london Demanding, Housing for Our Community";
            return View();
        }

        [HttpPost]
       // [ActionName("tent-city")]
        public ActionResult tentcity(email mail)
        {
            ViewBag.Description = "Party in the Park 2018 Tent City";
            ViewBag.Keywords = "housing stall, information on social housing, tenant empowerment, stop social cleansing in london";
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>A form from the Party in the Park Housing Area Info page has been sent - </p>");
            sb.Append("<p>Email: " + mail.Email + "</p>");
            sb.Append("<p>Message: " + mail.Message + "</p>");


            SendEmail.SendMail(sb.ToString(), "Tent City Info request from the PITP Web site ", mail.Email, "tentcity@pitpnxd.co.uk");
            ViewData["Message"] = "We appreciate you getting in touch. We will contact you shortly with a reply - The Party in the Park Team";
            ViewData["Sent"] = "sent";
            return View();
        }

        public ActionResult year2016()
        {
            ViewBag.Description = "Party in the Park held its third festival in 2016";
            ViewBag.Keywords = "Party, Park, festval, 2016, New Cross, Deptford";
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
                "Child steward",
                "Parking Steward"
            };

            vol.Skills = new[] {
                "First Aid training",
                "Health and Safety Training",
                "Working with children"
            };

            //vol.FirstAid = new[]
            //{
            //    "Yes",
            //    "No"
            //};

            vol.CRB = new []
            {
                "Yes",
                "No"
            };

            //vol.MadCap = false;


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

            //if (vol.FirstAid != null)
            //    {
            //        sb.Append("<p>Want's to take a First Aid course: ");
            //        foreach (string value in vol.FirstAid)
            //        {
            //            sb.Append("<br>" + value + " ");
            //        }
            //        sb.Append("</p>");
            //    }


            //if (vol.MadCap) sb.Append("<p>Is Interested in helping out with MadCap: " + vol.MadCap + "</p>");
            //    else sb.Append("<p>Is <b>not</b> Interested in helping out with MadCap: " + vol.MadCap + "</p>");

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


        public JsonResult DonutChartData()
        {

            // netTotal here is the sum total of all donations made
            // including sponsors and PayPal donors
            var netTotal = (from c in pc.formusers
                            where c.ppal.paid == true
                            select c.ppal.sAmountPaid).Sum();

            // totalBelow - sum of all paypal donations less than £100
            var totalBelow = (from c in pc.formusers
                              where c.ppal.sAmountPaid < 100 && c.ppal.paid == true
                              select c.ppal.sAmountPaid).Sum();

            // amountNeeded - what we are shy of from our budgeted total
            var amountNeeded = grandTotal - netTotal;
            amountNeeded = amountNeeded - raisersTodate;

            // IEnumerable of Names of all donations great or equal to £100
            // Convert to Array
            var orderNamesOver = (from c in pc.formusers
                                  where c.ppal.sAmountPaid >= 100 && c.ppal.paid == true && c.Name != "Anonymous"
                                  select c.Name).ToArray();

            // IEnumerable of anon PayPAl donations greater or £100
            // Convert to Array
            var anonNamesOver = (from c in pc.formusers
                                 where c.ppal.sAmountPaid >= 100 && c.ppal.paid == true && c.Name == "Anonymous"
                                 select c.Name + " " + "PayPal donation").ToArray();

            // Create New Array NamesOver defined with a length of orderNamesOver and anonNamesOver Arrays
            string[] NamesOver = new string[orderNamesOver.Length + anonNamesOver.Length];

            Array.Copy(orderNamesOver, NamesOver, orderNamesOver.Length);
            Array.Copy(anonNamesOver, 0, NamesOver, orderNamesOver.Length, anonNamesOver.Length);

            // resize orderNamesOver array to include three more fields 
            // Amount reamining - "Remaining", "Paypal donations", "Fund Raisers & Other Income"
            Array.Resize(ref NamesOver, NamesOver.Length + 3);
            NamesOver[NamesOver.Length - 3] = "Total Paypal donations below £100";
            NamesOver[NamesOver.Length - 2] = "Fund Raisers & Other Income";
            NamesOver[NamesOver.Length - 1] = "Remaining";


            // orderAmoutsOver - IEnumerable of all Amounts greater or equal to £100 not including Anon PayPal donations over £100
            // Convert to Array                     
            var orderAmountsOver = (from c in pc.formusers
                                    where c.ppal.sAmountPaid >= 100 && c.ppal.paid == true && c.Name != "Anonymous"
                                    select c.ppal.sAmountPaid).ToArray();

            // orderAmoutsOver - IEnumerable of all Anon PayPal  donations  Amounts greater or equal to £100
            // Convert to Array  
            var anonAmountsOver = (from c in pc.formusers
                                   where c.ppal.sAmountPaid >= 100 && c.ppal.paid == true && c.Name == "Anonymous"
                                   select c.ppal.sAmountPaid).ToArray();

            // Create new Array with a size defined by adding the length of orderAmoutsOver + anonAmountsOver
            decimal[] AmountsOver = new decimal[orderAmountsOver.Length + anonAmountsOver.Length];

            Array.Copy(orderAmountsOver, AmountsOver, orderAmountsOver.Length);
            Array.Copy(anonAmountsOver, 0, AmountsOver, orderAmountsOver.Length, anonAmountsOver.Length);

            // resize orderAmoutsOver array to include three more fields 
            // Fundraisers & income to date, sum of all paypal donations less than £100, amountNeeded - what we are shy of from our budgeted total
            Array.Resize(ref AmountsOver, AmountsOver.Length + 3);
            AmountsOver[AmountsOver.Length - 3] = totalBelow;
            AmountsOver[AmountsOver.Length - 2] = raisersTodate;
            AmountsOver[AmountsOver.Length - 1] = amountNeeded;


            Chart _chart = new Chart();
            _chart.labels = NamesOver;
            _chart.datasets = new List<Datasets>();
            List<Datasets> _dataSet = new List<Datasets>();

            _dataSet.Add(new Datasets()
            {
                label = "Current Year",               
                data = AmountsOver,
                backgroundColor = new string[] { "#fff", "#800000", "#386db9", "#2cca31", "#ed1c24", "#386db9", "#00ade5", "#fff200", "#222" },
                borderColor = new string[] { "#fff", "#800000", "#386db9", "#2cca31", "#ed1c24", "#386db9", "#00ade5", "#fff200", "#222" },
                borderWidth = "3"
            });

            _chart.datasets = _dataSet;
            return Json(_chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BarChartData()
        {

            Chart _chart = new Chart();
            _chart.labels = new string[] { "Power Generators", "Toilets", "Transport", "Fencing", "Insurance", "Licences", "Security", "Tent City", "Community Arts", "Wango stage", "Merchandise", "St Johns", "Stewarding", "Admin" };
            _chart.datasets = new List<Datasets>();
            List<Datasets> _dataSet = new List<Datasets>();
            _dataSet.Add(new Datasets()
            {
                label = "Current Year",
                data = new decimal[] { 1200, 1450, 120, 213, 390, 63, 1500, 500, 400, 500, 550, 193, 300, 50 },
                backgroundColor = new string[] { "#FF0000", "#800000", "#808000", "#008080", "#800080", "#0000FF", "#000080", "#999999", "#E9967A", "#CD5C5C", "#1A5276", "#006633", "#800000", "#808000" },
                borderColor = new string[] { "#FF0000", "#800000", "#808000", "#008080", "#800080", "#0000FF", "#000080", "#999999", "#E9967A", "#CD5C5C", "#1A5276", "#006633", "#800000", "#808000" },
                borderWidth = "1"
            });
            _chart.datasets = _dataSet;
            return Json(_chart, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSponsors()
        {
            var spview = from c in pc.formusers
                         where c.ppal.paid == true
                            select new sponsorview
                            {
                                contribution = c.ppal.sAmountPaid.ToString(),
                                fullName = c.Name,
                                message = c.Message,
                                SubmitTime = c.SubmitTime
                            };

            var retview = spview.ToList<sponsorview>();

            return PartialView(retview);
        }

        public ActionResult Donate()
        {
            var netTotal = (from d in pc.formusers
                            where d.ppal.paid == true
                            select d.ppal.sAmountPaid).Sum();

            var amountNeeded = grandTotal - netTotal;
            amountNeeded = amountNeeded - raisersTodate;


            ViewBag.GrandTotal = string.Format("{0:C}", grandTotal);
            ViewBag.AmountNeeded = string.Format("{0:C}", amountNeeded);
            return View();
        }

        [HttpPost]
        public ActionResult Donate(FormView fw)
        {
            if (ModelState.IsValid)
            {
                string sentName;
                if (String.IsNullOrEmpty(fw.Name) || fw.Name == "Anonymous")
                {
                    sentName = "Anonymous";
                }
                else sentName = fw.Name;

                formuser fu = new formuser
                {
                    Message = fw.Message,
                    SubmitTime = DateTime.Now,
                    ppal = new ppal
                    {
                        paid = false,
                        sAmountPaid = fw.amount,
                        transactionId = null
                    },
                    Name = sentName
                };

                pc.formusers.Add(fu);
                pc.SaveChanges();

                RemotePost myremotepost = new RemotePost();
                myremotepost.Url = "https://www.paypal.com/cgi-bin/webscr";
                //myremotepost.Url = "https://www.sandbox.paypal.com/cgi-bin/webscr";
                myremotepost.Add("cmd", "_donations");
                myremotepost.Add("item_name", "Party in the Park 2018 - Donation");
                // live paypal id
                myremotepost.Add("business", "AQF49WHBFF5XN");
                // sandbox id
                //myremotepost.Add("business", "56LULGKTVTCNL");
                myremotepost.Add("amount", fu.ppal.sAmountPaid.ToString());
                myremotepost.Add("no_note", "1");
                myremotepost.Add("currency_code", "GBP");
                myremotepost.Add("notify_url", "http://pitpnxd.co.uk/ipn/receive");
                myremotepost.Add("custom", fu.ID.ToString());
                myremotepost.Add("return", "http://pitpnxd.co.uk/paypal/thankyou");
                myremotepost.Post();
                return View();
            }
            else
            {
                return View(fw);
            }
        }
    }
}
