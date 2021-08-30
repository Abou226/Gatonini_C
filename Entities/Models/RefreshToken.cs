using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("RefreshToken")]
    public class RefreshToken
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Le token est requis")]
        public string Token { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public Guid? UserId { get; set; }

        [Required(ErrorMessage ="Refreshable est requis")]
        [StringLength(60, ErrorMessage = "La taille de refreshable ne peut dépasser 60 characters")]
        public string Refreshable { get; set; }
    }
}
