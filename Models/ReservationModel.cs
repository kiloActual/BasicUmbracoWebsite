using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace MyUmbracoProject.Models
{
    public class ReservationModel
    { 
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public string  Email { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }
        public string date { get; set; }
        public string Time { get; set; }
        public string Person { get; set; }
    }

    public enum OrderTime
    {
        [Description("10:00am-11:00am")]
        morning = 1,
        [Description("12:00pm-1:00pm")]
        afternoon = 2,
        [Description("7:00pm-8:00pm")]
        evening = 3,
        [Description("9:00pm-10:00pm")]
        night = 4,
    };

    public enum number
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4
    };
}
