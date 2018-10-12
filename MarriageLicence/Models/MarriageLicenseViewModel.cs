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
        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Proposed Place of Marriage (town/city)")]
        public string ProposedPlaceofMarriage { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Proposed Date of Marriage (yyyy/mm/dd must be withing 3 months of date of issue)")]
        public string ProposedDateofMarriage { get; set; }

        //-----------APPLICANT---------------------------------------------
        //-----------------------------------------------------------------
        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Current last name or single name")]
        public string ApplicantLastOrSingle { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "First and middle names")]
        public string ApplicantFirstAndMiddle { get; set; }
              
        public bool ApplicantNeverMarried { get; set; }
        
        public bool ApplicantWidowed { get; set; }

        public bool ApplicantDivorced { get; set; }

        [Display(Name = "If divorced, country of divorce")]
        public string ApplicantCountryOfDivorce { get; set; }

        [Display(Name = "City of divorce, if in Canada")]
        public string ApplicantCityOfDivorce { get; set; }

        [Display(Name = "Court file number")]
        public string ApplicantCourtFileNumber { get; set; }

        [Display(Name = "Religious denomination")]
        public string ApplicantReligiousDenomination { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Age")]
        public string ApplicantAge { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Date of birth yyyy/mm/dd")]
        public string ApplicantDateOfBirth { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Province where applicant was born(if outside Canada, state the country)")]
        public string ApplicantPlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string ApplicantParent1Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string ApplicantParent1PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string ApplicantParent2Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string ApplicantParent2PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string ApplicantParent3Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string ApplicantParent3PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string ApplicantParent4Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string ApplicantParent4PlaceOfBirth { get; set; }
        
        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Present address of applicant(street number and name")]
        public string ApplicantAddress { get; set; }
        
        [Display(Name = "Apartment")]
        public string ApplicantAppartment { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "City")]
        public string ApplicantCity { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Province")]
        public string ApplicantProvince { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Postal Code")]
        public string ApplicantPostalCode { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Telephone number")]
        public string ApplicantTelephoneNumber { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------

        //-----------JOINT APPLICANT-------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------
        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Current last name or single name")]
        public string JointApplicantLastOrSingle { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "First and middle names")]
        public string JointApplicantFirstAndMiddle { get; set; }

        public bool JointApplicantNeverMarried { get; set; }

        public bool JointApplicantWidowed { get; set; }

        public bool JointApplicantDivorced { get; set; }

        [Display(Name = "If divorced, country of divorce")]
        public string JointApplicantCountryOfDivorce { get; set; }

        [Display(Name = "City of divorce, if in Canada")]
        public string JointApplicantCityOfDivorce { get; set; }

        [Display(Name = "Court file number")]
        public string JointApplicantCourtFileNumber { get; set; }

        [Display(Name = "Religious denomination")]
        public string JointApplicantReligiousDenomination { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Age")]
        public string JointApplicantAge { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Date of birth yyyy/mm/dd")]
        public string JointApplicantDateOfBirth { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Province where applicant was born(if outside Canada, state the country)")]
        public string JointApplicantPlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string JointApplicantParent1Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string JointApplicantParent1PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string JointApplicantParent2Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string JointApplicantParent2PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string JointApplicantParent3Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string JointApplicantParent3PlaceOfBirth { get; set; }

        [Display(Name = "Parent's name(last,first and middle or single name")]
        public string JointApplicantParent4Name { get; set; }

        [Display(Name = "Province where the applicant's parent was born(if outside of Canada, state the country")]
        public string JointApplicantParent4PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Present address of applicant(street number and name")]
        public string JointApplicantAddress { get; set; }

        [Display(Name = "Apartment")]
        public string JointApplicantAppartment { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "City")]
        public string JointApplicantCity { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Province")]
        public string JointApplicantProvince { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Postal Code")]
        public string JointApplicantPostalCode { get; set; }

        [Required(ErrorMessage = "**Required Field")]
        [Display(Name = "Telephone number")]
        public string JointApplicantTelephoneNumber { get; set; }

    }
}