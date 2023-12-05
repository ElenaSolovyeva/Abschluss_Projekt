using System;
using System.ComponentModel.DataAnnotations;

namespace MaterialStatus.Domains.Entities
{
    public class UsersGroup
    {
        protected UsersGroup()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Benennung von der Benutzergruppe")]
        public virtual string Name { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}


