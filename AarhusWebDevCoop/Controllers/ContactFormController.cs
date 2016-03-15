using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace AarhusWebDevCoop.Controllers
{
    public class ContactFormController : SurfaceController
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            return PartialView("ContactForm");
        }
    }
}