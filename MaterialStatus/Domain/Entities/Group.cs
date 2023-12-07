using System;
using System.ComponentModel.DataAnnotations;

namespace MaterialStatus.Domain.Entities
{
    public class Group
    {
        protected Group()
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


