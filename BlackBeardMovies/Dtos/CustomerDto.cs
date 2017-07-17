﻿using BlackBeardMovies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBeardMovies.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer's Name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public CustomerDto(Customer newCustomer)
        {
            this.Id = newCustomer.Id;
            this.Name = newCustomer.Name;
            this.MembershipTypeId = newCustomer.MembershipTypeId;
            this.MembershipType = new MembershipTypeDto { Id = newCustomer.MembershipType.Id, Name = newCustomer.MembershipType.Name };
            this.Birthdate = newCustomer.Birthdate;
        }

        public CustomerDto()
        {

        }
    }
}