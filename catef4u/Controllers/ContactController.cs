using catef4u.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Net.Mail;

using Umbraco.Core.Models;

namespace catef4u.Controllers
{
    public class ContactController : SurfaceController
    {
        public ActionResult RenderForm()
        {
            return PartialView("~/Views/Shared/contactMe.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();
            /// Work with form data here
            TempData["contactSuccess"] = true;
            IPublishedContent currentNode = Umbraco.TypedContent(CurrentPage.Id);
            string nm = currentNode.Name;
            SendEmail(model,nm);
            ////////////////////////////
            return RedirectToCurrentUmbracoPage();
        }

        private void SendEmail(ContactFormViewModel model,string nm)
        {
            try
            {
                if(IsValidEmail(model.Email))
                {
                    MailMessage m = new MailMessage(model.Email, "loria3@gmail.com");
                    m.Subject = "פניה מהאתר- שם הדף:  " + nm;
                    m.Body = model.Message;
                    SmtpClient client = new SmtpClient("127.0.0.1", 25);

                    client.Send(m);
                }
            }
            catch(Exception ex)
            {
                Console.Write("Exception " + ex.ToString());
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}