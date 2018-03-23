using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        //public DateTime BirthDate { get; set; }

        [Display(Name = "Date of Birth")] // Adnotarea este folosita pentru a afisa in form label-ul Date of Birth
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        //Navigation properties
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}