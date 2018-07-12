using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly3.Models;

namespace Vidly3.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}