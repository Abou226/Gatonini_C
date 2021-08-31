using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("ExternalLogin")]
    public class ExternalLogin
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom du provider est requis")]
        [StringLength(40, ErrorMessage = "Le nom du provider ne peut dépasser 40 characters")]
        public string Provider { get; set; }

        [Required(ErrorMessage = "Le token du provider est requis")]
        public string Token { get; set; }

        [Required(ErrorMessage = "La date du login est requise")]
        public DateTime DateOfLogin { get; set; }
        [Required(ErrorMessage = "La date d'expiration est requise")]
        public DateTime DateOfExpiry { get; set; }

        //[ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        //public User User { get; set; }
    }
}
