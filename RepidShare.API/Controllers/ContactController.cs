using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RepidShare.Entities;
using RepidShare.Business;

namespace RepidShare.API.Controllers
{
    public class ContactController : ApiController
    {
        private BLContact objBLContact = new BLContact();

        [HttpPost]
        public ContactModel InsertContactUSDetails(ContactModel objContactModel)
        {
            return objBLContact.InsertContactUSDetails(objContactModel);
        }
    }
}
