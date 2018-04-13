using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SSRSEmailForm.Models
{
    public class TestViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Your Name*")]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Context*")]
        public string Context { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Pain Point/Problem*")]
        public string Problem { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "What is the goal of this deliverable?*")]
        public string Goal { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Link to Existing Report (if applicable)")]
        public string ReportLink { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
        //[Display(Name = "OMSID")]
        //public string OMSID { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[Display(Name = "Date of Incident")]
        //public string IncidentDate { get; set; }

        //[Required]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Issue Description")]
        //public string Message { get; set; }

        //[DataType(DataType.Text)]
        //[Display(Name = "Priority")]
        //public string Priority { get; set; }

    }
}