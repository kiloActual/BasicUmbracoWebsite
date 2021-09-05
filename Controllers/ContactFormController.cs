using Microsoft.AspNetCore.Mvc;
using MyUmbracoProject.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Filters;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Cms.Web.Common.Controllers;


namespace MyUmbracoProject.Controllers
{
    public class ContactFormController : SurfaceController
    {
        public ContactFormController(IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ValidateUmbracoFormRouteString]
        public IActionResult SubmitForm(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                var htmlMessage = $"Name : {model.Name} \n Message : {model.Message}"; 

                EmailSender email = new EmailSender();
                email.SendEmailAsync(model.Email, model.Subject, htmlMessage);
                TempData["contactResult"] = "Email Has Been Sent.";
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
 
    }
}
