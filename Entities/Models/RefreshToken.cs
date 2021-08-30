using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Models
{
    [Table("RefreshToken")]
    public partial class RefreshToken
    {
        public Guid RefreshTokenId { get; set; }
        public string Token { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Refreshable { get; set; }
        public int? UserId { get; set; }
        public DateTime ServerTime { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int? AuteurId { get; set; }

        public virtual TblUser Auteur { get; set; }
        public virtual TblUser User { get; set; }
    }
}
