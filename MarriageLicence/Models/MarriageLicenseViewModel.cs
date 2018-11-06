using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MarriageLicence.LicenseService;

namespace MarriageLicence.Models
{
    public class MarriageLicenseViewModel
    {
        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Proposed Place of Marriage (town/city)")]
        public string ProposedPlaceofMarriage { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\d{4}[\-\/\s]?((((0[13578])|(1[02]))[\-\/\s]?(([0-2][0-9])|(3[01])))|(((0[469])|(11))[\-\/\s]?(([0-2][0-9])|(30)))|(02[\-\/\s]?[0-2][0-9]))$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Proposed Date of Marriage")]
        public string ProposedDateofMarriage { get; set; }

        //-----------APPLICANT---------------------------------------------
        //-----------------------------------------------------------------
        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Current last name or single name")]
        public string ApplicantLastOrSingle { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "First and middle names")]
        public string ApplicantFirstAndMiddle { get; set; }

        [Display(Name = "Never Married")]
        public bool ApplicantNeverMarried { get; set; }

        [Display(Name = "Widowed")]
        public bool ApplicantWidowed { get; set; }

        [Display(Name = "Divorced")]
        public bool ApplicantDivorced { get; set; }

        [StringLength(100)]
        [Display(Name = "Country of divorce")]
        public string ApplicantCountryOfDivorce { get; set; }

        [StringLength(100)]
        [Display(Name = "City of divorce")]
        public string ApplicantCityOfDivorce { get; set; }

        [StringLength(100)]
        [Display(Name = "Court file number")]
        public string ApplicantCourtFileNumber { get; set; }

        [StringLength(100)]
        [Display(Name = "Religious denomination")]
        public string ApplicantReligiousDenomination { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"\b(1[89]|[2-9][0-9])\b", ErrorMessage = "*Invalid Age")]
        [Display(Name = "Age")]
        public string ApplicantAge { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\d{4}[\-\/\s]?((((0[13578])|(1[02]))[\-\/\s]?(([0-2][0-9])|(3[01])))|(((0[469])|(11))[\-\/\s]?(([0-2][0-9])|(30)))|(02[\-\/\s]?[0-2][0-9]))$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Date of birth")]
        public string ApplicantDateOfBirth { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Province where applicant was born(if outside Canada, state the country)")]
        public string ApplicantPlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 1 name(last,first and middle or single name")]
        public string ApplicantParent1Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string ApplicantParent1PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 2 name(last,first and middle or single name")]
        public string ApplicantParent2Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string ApplicantParent2PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 3 name(last,first and middle or single name")]
        public string ApplicantParent3Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string ApplicantParent3PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 4 name(last,first and middle or single name)")]
        public string ApplicantParent4Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string ApplicantParent4PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Present Address (street number and name)")]
        public string ApplicantAddress { get; set; }

        [StringLength(100)]
        [Display(Name = "Apartment")]
        public string ApplicantAppartment { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "City")]
        public string ApplicantCity { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Province")]
        public string ApplicantProvince { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Postal Code")]
        public string ApplicantPostalCode { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Telephone number")]
        public string ApplicantTelephoneNumber { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------

        //-----------JOINT APPLICANT-------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------
        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Current last name or single name")]
        public string JointApplicantLastOrSingle { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "First and middle names")]
        public string JointApplicantFirstAndMiddle { get; set; }

        [Display(Name = "Never Married")]
        public bool JointApplicantNeverMarried { get; set; }

        [Display(Name = "Widowed")]
        public bool JointApplicantWidowed { get; set; }

        [Display(Name = "Divorced")]
        public bool JointApplicantDivorced { get; set; }

        [StringLength(100)]
        [Display(Name = "Country of divorce")]
        public string JointApplicantCountryOfDivorce { get; set; }

        [StringLength(100)]
        [Display(Name = "City of divorce")]
        public string JointApplicantCityOfDivorce { get; set; }

        [StringLength(100)]
        [Display(Name = "Court file number")]
        public string JointApplicantCourtFileNumber { get; set; }

        [StringLength(100)]
        [Display(Name = "Religious denomination")]
        public string JointApplicantReligiousDenomination { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Age")]
        [RegularExpression(@"\b(1[89]|[2-9][0-9])\b", ErrorMessage = "*Invalid Age")]
        public string JointApplicantAge { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\d{4}[\-\/\s]?((((0[13578])|(1[02]))[\-\/\s]?(([0-2][0-9])|(3[01])))|(((0[469])|(11))[\-\/\s]?(([0-2][0-9])|(30)))|(02[\-\/\s]?[0-2][0-9]))$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Date of birth")]
        public string JointApplicantDateOfBirth { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Province where applicant was born(if outside Canada, state the country)")]
        public string JointApplicantPlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 1 name(last,first and middle or single name)")]
        public string JointApplicantParent1Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string JointApplicantParent1PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 2 name(last,first and middle or single name)")]
        public string JointApplicantParent2Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string JointApplicantParent2PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 3 name(last,first and middle or single name)")]
        public string JointApplicantParent3Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string JointApplicantParent3PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Display(Name = "Parent 4 name(last,first and middle or single name)")]
        public string JointApplicantParent4Name { get; set; }

        [StringLength(100)]
        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country)")]
        public string JointApplicantParent4PlaceOfBirth { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Present Address (street number and name)")]
        public string JointApplicantAddress { get; set; }

        [StringLength(100)]
        [Display(Name = "Apartment")]
        public string JointApplicantAppartment { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "City")]
        public string JointApplicantCity { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Province")]
        public string JointApplicantProvince { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$", ErrorMessage = "*Wrong format")]

        [Display(Name = "Postal Code")]
        public string JointApplicantPostalCode { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "*Wrong format")]
        [Display(Name = "Telephone number")]
        public string JointApplicantTelephoneNumber { get; set; }

        [Required(ErrorMessage = "*Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "*Wrong Format")]
        [Display(Name = "Email Address (A Printable version of this Marriage License will be sent to this address)")]
        public string EmailAddress { get; set; }

    }
}