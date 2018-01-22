using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RepidShare.Entities.Resource;
namespace RepidShare.Entities
{
    public class ContactModel : BaseModel
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [LocalizedDisplayName(typeof(CommonResource), "lblContactFirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [LocalizedDisplayName(typeof(CommonResource), "lblContactLastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Daytime contact number is required.")]
        [LocalizedDisplayName(typeof(CommonResource), "lblDaytimeContactNumber")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int? DaytimeContactNumber { get; set; }
        [LocalizedDisplayName(typeof(CommonResource), "lblMobileTelephoneNumber")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int? MobileTelephoneNumber { get; set; }
        [Required(ErrorMessage ="Email addresss is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is not valid")]
        [LocalizedDisplayName(typeof(CommonResource),"lblContactEmailAddress")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Message is required.")]
        [StringLength(500,ErrorMessage = "Message lenght should not be more than 500.")]
        [LocalizedDisplayName(typeof(CommonResource),"lblContactMessage")]
        public string MessageBody { get; set; }
    }
}
