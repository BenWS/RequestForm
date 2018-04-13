using System.Web.Mvc;
using SSRSEmailForm.Models;
using System;
using System.Net;


namespace SSRSEmailForm.Controllers
{
    public class InquiryController : Controller
    {
        // GET: Inquiry
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test(TestViewModel model)
        {
           if (ModelState.IsValid)
            {
                string Name = model.Name;
                string Context = model.Context;
                string Problem = model.Problem;
                string Goal = model.Goal;
                string ReportLink = model.ReportLink;

                string Description = " **Name:** " + Name + "; **Context:** " + Context + "; **Problem:** " + Problem + "; **Goal:** " + Goal + "; **Report Link:** " + ReportLink;
 

                //testing POST request
                WebClient POSTRequest = new WebClient();
                POSTRequest.Headers.Add("X-TrackerToken", "88d0f88e91f947e429be584041fecb50");
                POSTRequest.Headers.Add("Content-Type", "application/json");

                string post_url = "https://www.pivotaltracker.com/services/v5/projects/1984545/stories";
                string data = "{\"name\":\"API Testing - Please disregard\", \"description\":\"" + Description + "\"}";
                string post_result = POSTRequest.UploadString(post_url, data);

                ModelState.Clear();
                return Redirect("Inquiry/Success");
            } else {
                return View();
            }
        }
    }
}