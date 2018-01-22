using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepidShare.Entities;
using RepidShare.Data;

namespace RepidShare.Business
{
    public class BLContact
    {
        private DLContact objDLContact = new DLContact();
        /// <summary>
        /// Insert ContactUS details
        /// </summary>
        /// <param name="objContactModel">object of ContactModel</param>
        /// <param name="ErrorCode"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        public ContactModel InsertContactUSDetails(ContactModel objContactModel)
        {
            //call InsertUpdateContact Method of dataLayer and return ContactModel
            return objDLContact.InsertContactUSDetails(objContactModel);
        }
    }
}
