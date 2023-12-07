﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MaterialStatus.Domain.Entities
{
    public class AppUser
    {
        public AppUser()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Vorname")]
        public virtual string FirstName { get; set; }

        [Display(Name = "Nachname")]
        public virtual string LastName { get; set; }

        [Display(Name = "Gruppe")]
        public virtual string Group { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
