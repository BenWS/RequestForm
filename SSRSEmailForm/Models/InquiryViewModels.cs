using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SSRSEmailForm.Models
{
    public class TestViewModel
    {
        //'Required' attribute makes value for the Name property required when submitting the form
        [Required]
        //DataType property sets the type of data the form accepts, and adjusts the form UI to match that data type
        [DataType(DataType.Text)]
        //Display Property sets the label for the form field
        [Display(Name = "Your Name*")]
        //This line is doing...
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

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Link to Existing Report (if applicable)")]
        public string ReportLink { get; set; }
    }

    //public class FormViewModel
    //{
    //    //'Required' attribute makes value for the Name property required when submitting the form
    //    [Required]
    //    //DataType property sets the type of data the form accepts, and adjusts the form UI to match that data type
    //    [DataType(DataType.Text)]
    //    //Display Property sets the label for the form field
    //    [Display(Name = "Your Name*")]
    //    //This line is doing...
    //    public string Name { get; set; }

    //    [Required]
    //    [DataType(DataType.MultilineText)]
    //    [Display(Name = "Context*")]
    //    public string Context { get; set; }

    //    [Required]
    //    [DataType(DataType.MultilineText)]
    //    [Display(Name = "Pain Point/Problem*")]
    //    public string Problem { get; set; }

    //    [Required]
    //    [DataType(DataType.MultilineText)]
    //    [Display(Name = "What is the goal of this deliverable?*")]
    //    public string Goal { get; set; }

    //    [DataType(DataType.MultilineText)]
    //    [Display(Name = "Link to Existing Report (if applicable)")]
    //    public string ReportLink { get; set; }
    //}
}