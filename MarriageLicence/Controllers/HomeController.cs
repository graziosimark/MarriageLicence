using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarriageLicence.Models;
using MarriageLicence.LicenseService;

namespace MarriageLicence.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MarriageLicenseViewModel vm)
        {

            if (ModelState.IsValid)
            {

                LicenseService.MarriageLicense ml = new LicenseService.MarriageLicense();
                Repository r = new Repository();


                ml.ProposedPlaceOfMarriage = vm.ProposedPlaceofMarriage;
                ml.ProposedDateOfMarriage = Convert.ToDateTime(vm.ProposedDateofMarriage);
                ml.ApplicantLastOrSingle = vm.ApplicantLastOrSingle;
                ml.ApplicantFirstAndMiddle = vm.ApplicantFirstAndMiddle;
                ml.ApplicantNeverMarried = vm.ApplicantNeverMarried;
                ml.ApplicantWidowed = vm.ApplicantWidowed;
                ml.ApplicantDivorced = vm.ApplicantDivorced;
                ml.ApplicantCountryOfDivorce = vm.ApplicantCountryOfDivorce;
                ml.ApplicantCityOfDivorce = vm.ApplicantCityOfDivorce;
                ml.ApplicantCourtFileNumber = vm.ApplicantCourtFileNumber;
                ml.ApplicantReligiousDenomination = vm.ApplicantReligiousDenomination;
                ml.ApplicantAge = Convert.ToInt16(vm.ApplicantAge);
                ml.ApplicantDateOfBirth = Convert.ToDateTime(vm.ApplicantDateOfBirth);
                ml.ApplicantPlaceOfBirth = vm.ApplicantPlaceOfBirth;
                ml.ApplicantParent1Name = vm.ApplicantParent1Name;
                ml.ApplicantParent1PlaceOfBirth = vm.ApplicantParent1PlaceOfBirth;
                ml.ApplicantParent2Name = vm.ApplicantParent2Name;
                ml.ApplicantParent2PlaceOfBirth = vm.ApplicantParent2PlaceOfBirth;
                ml.ApplicantParent3Name = vm.ApplicantParent3Name;
                ml.ApplicantParent3PlaceOfBirth = vm.ApplicantParent3PlaceOfBirth;
                ml.ApplicantParent4Name = vm.ApplicantParent4Name;
                ml.ApplicantParent4PlaceOfBirth = vm.ApplicantParent4PlaceOfBirth;
                ml.ApplicantAddress = vm.ApplicantAddress;
                ml.ApplicantApartment = vm.ApplicantAppartment;
                ml.ApplicantCity = vm.ApplicantCity;
                ml.ApplicantProvince = vm.ApplicantProvince;
                ml.ApplicantPostalCode = vm.ApplicantPostalCode;
                ml.ApplicantTelephoneNumber = vm.ApplicantTelephoneNumber;

                ml.JointApplicantLastOrSingle = vm.JointApplicantLastOrSingle;
                ml.JointApplicantFirstAndMiddle = vm.JointApplicantFirstAndMiddle;
                ml.JointApplicantNeverMarried = vm.JointApplicantNeverMarried;
                ml.JointApplicantWidowed = vm.JointApplicantWidowed;
                ml.JointApplicantDivorced = vm.JointApplicantDivorced;
                ml.JointApplicantCountryOfDivorce = vm.JointApplicantCountryOfDivorce;
                ml.JointApplicantCityOfDivorce = vm.JointApplicantCityOfDivorce;
                ml.JointApplicantCourtFileNumber = vm.JointApplicantCourtFileNumber;
                ml.JointApplicantReligiousDenomination = vm.JointApplicantReligiousDenomination;
                ml.JointApplicantAge = Convert.ToInt16(vm.JointApplicantAge);
                ml.JointApplicantDateOfBirth = Convert.ToDateTime(vm.JointApplicantDateOfBirth);
                ml.JointApplicantPlaceOfBirth = vm.JointApplicantPlaceOfBirth;
                ml.JointApplicantParent1Name = vm.JointApplicantParent1Name;
                ml.JointApplicantParent1PlaceOfBirth = vm.JointApplicantParent1PlaceOfBirth;
                ml.JointApplicantParent2Name = vm.JointApplicantParent2Name;
                ml.JointApplicantParent2PlaceOfBirth = vm.JointApplicantParent2PlaceOfBirth;
                ml.JointApplicantParent3Name = vm.JointApplicantParent3Name;
                ml.JointApplicantParent3PlaceOfBirth = vm.JointApplicantParent3PlaceOfBirth;
                ml.JointApplicantParent4Name = vm.JointApplicantParent4Name;
                ml.JointApplicantParent4PlaceOfBirth = vm.JointApplicantParent4PlaceOfBirth;
                ml.JointApplicantAddress = vm.JointApplicantAddress;
                ml.JointApplicantApartment = vm.JointApplicantAppartment;
                ml.JointApplicantCity = vm.JointApplicantCity;
                ml.JointApplicantProvince = vm.JointApplicantProvince;
                ml.JointApplicantPostalCode = vm.JointApplicantPostalCode;
                ml.JointApplicantTelephoneNumber = vm.JointApplicantTelephoneNumber;
                ml.ResidentEmail = vm.EmailAddress;

                wsResponse x;

                x = r.SubmitApplication(ml);

                ViewBag.ResponseID = x.PrimaryKeyId.ToString();
                ViewBag.EmailAddress = vm.EmailAddress;
                return View("Complete");
                
            }
            else

                  {

                return View(vm);
            }

                
        }


    }
}