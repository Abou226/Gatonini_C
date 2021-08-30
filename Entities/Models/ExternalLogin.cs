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

        [Required(ErrorMessage = "Le provider est requis")]
        [StringLength(60, ErrorMessage ="La taille du provider ne peut dépasser 60 characters")]
        public string Provider { get; set; }
        public Guid? UserId { get; set; }
        public DateTime DateOfLogin { get; set; }
        public string Token { get; set; }

    }
}
