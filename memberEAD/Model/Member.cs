using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace memberEAD.Model
{
    public class Member
    {


        //[Key]

        //the StudentID is set as the primary key for the database
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//generating ID for applicant

        public int MemberID { get; set; }


        [BindProperty]
        [Required]
        [RegularExpression(@"([\w\s'.-]){2,50}", ErrorMessage = "First name must be between 2 and 60 characters. ")] //validation regular expression
        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Please enter your  first name:")]
        public string FirstName { get; set; } = "";


        [BindProperty]
        [Required]
        [RegularExpression(@"([\w\s'.-]){2,50}", ErrorMessage = "First name must be between 2 and 60 characters. ")] //validation regular expression
        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Please enter your  first name:")]
        public string LastName { get; set; } = "";




        [BindProperty]
        [Required]
        [Display(Name = "Please enter  DOB:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyy}", ApplyFormatInEditMode = true)]
        [DOB]
        public DateTime DOB { get; set; }

        [Required]
        [RegularExpression(@"\d{7}([a-z]{1,2}|[A-Z]{1,2})", ErrorMessage = "Just to remind you that your PPS must start with 7 numbers and followed by 2 letters.")]
        [Display(Name = "PPS Number")]
        public string PPS { get; set; }

        [BindProperty]
        [Required, DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Is this a correct email address?")]
        [Display(Name = "Please enter your email: ")]
        public string Email { get; set; }


        [BindProperty]
        [Required]
        [Display(Name = "Please enter your childs gender:")]
        
        public string Gender { get; set; }


        [BindProperty]
        public bool Mondays { get; set; }

        [BindProperty]
        public bool Tuesday { get; set; }

        [BindProperty]
        public bool Wednesday { get; set; }

        [BindProperty]
        public bool Thursday { get; set; }

        [BindProperty]
        public bool Friday { get; set; }


    }
}
