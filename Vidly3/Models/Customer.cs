using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly3.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
            
        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Date of Birth" )]
        [Column(TypeName = "datetime2")]
        [Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }
    }
}