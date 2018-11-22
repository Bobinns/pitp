using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using PITP.Models;

namespace PITP.Controllers
{
    public class IPNController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public HttpStatusCodeResult Receive()
        {
            //Store the IPN received from PayPal
            LogRequest(Request);

            //Fire and forget verification task
            Task.Run(() => VerifyTask(Request));

            //Reply back a 200 code
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        private void VerifyTask(HttpRequestBase ipnRequest)
        {
            var verificationResponse = string.Empty;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                // sandbox version
                //var verificationRequest = (HttpWebRequest)WebRequest.Create("https://www.sandbox.paypal.com/cgi-bin/webscr");

                // live version
                var verificationRequest = (HttpWebRequest)WebRequest.Create("https://www.paypal.com/cgi-bin/webscr");

                //Set values for the verification request
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";
                var param = Request.BinaryRead(ipnRequest.ContentLength);
                var strRequest = Encoding.ASCII.GetString(param);

                //Add cmd=_notify-validate to the payload
                strRequest = "cmd=_notify-validate&" + strRequest;
                verificationRequest.ContentLength = strRequest.Length;

                //Attach payload to the verification request
                var streamOut = new StreamWriter(verificationRequest.GetRequestStream(), Encoding.ASCII);
                streamOut.Write(strRequest);
                streamOut.Close();

                //Send the request to PayPal and get the response
                var streamIn = new StreamReader(verificationRequest.GetResponse().GetResponseStream());
                verificationResponse = streamIn.ReadToEnd();
                streamIn.Close();

            }
            catch (Exception exception)
            {
                log.Info(exception.Message);
            }

            ProcessVerificationResponse(verificationResponse);
        }


        private void LogRequest(HttpRequestBase request)
        {
            // Persist the request values into a database or temporary data store
            log.Info("IPN Request");
        }

        private void ProcessVerificationResponse(string verificationResponse)
        {
            if (verificationResponse.Equals("VERIFIED"))
            {
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment

                string transactionID = Request["txn_id"];
                decimal sAmountPaid = decimal.Parse(Request["mc_gross"]);
                Int32 ID = Convert.ToInt32(Request["custom"]);

                using (ppaluserContext db = new ppaluserContext())
                {

                    bool varhas = db.formusers.Any(order => order.ID == ID);

                    var result = db.formusers.SingleOrDefault(b => b.ID == ID);

                    if (result != null)
                    {
                        result.ppal.paid = true;
                        result.ppal.transactionId = transactionID;
                        db.SaveChanges();
                    }
                }
            }
            else if (verificationResponse.Equals("INVALID"))
            {
                log.Info("ProcessVerificationResponse is INVALID");
                //Log for manual investigation
            }
            else
            {
                log.Info("ProcessVerificationResponse problem");
            }
        }
    }
}