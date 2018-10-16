using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarriageLicence.LicenseService;

namespace MarriageLicence.Models
{
    public class Repository
    {

        public LicensingServiceClient db = new LicensingServiceClient();

        
        public Repository()
        {
            this.db = new LicensingServiceClient();
        }

       public wsResponse SubmitApplication(MarriageLicense l)
        {

            wsResponse r = db.AddMarriageLicense(l);
            return r;
        }
        
    }

    

    }

  