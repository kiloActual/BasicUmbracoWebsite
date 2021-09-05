using Microsoft.AspNetCore.Mvc;
using MyUmbracoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Filters;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;

namespace MyUmbracoProject.Controllers
{
    public class ReservationController : SurfaceController
    {
      
        public ReservationController(IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {

        }

        [HttpPost]
        [ValidateUmbracoFormRouteString]
        public IActionResult Submit(ReservationModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Invalid Input..";
                return CurrentUmbracoPage();
            }
                

            var contentService = Services.ContentService;

            var parentId = new Guid("bc9eb564-4a6c-4b5c-84a4-aecbe7894c26");

            var reservation = contentService.Create(model.Name, parentId, Reservation.ModelTypeAlias);

            reservation.SetValue("reservationName",model.Name);
            reservation.SetValue("reservationEmail", model.Email);
            reservation.SetValue("reservationPhone", model.Phone);
            reservation.SetValue("reservationDate", model.date);
            reservation.SetValue("reservationTime", model.Time);
            reservation.SetValue("reservationPerson", model.Person);

            contentService.SaveAndPublish(reservation);

            TempData["success"] = "Successfully Submited..";
            
            return RedirectToCurrentUmbracoPage();
        }
    }
}
