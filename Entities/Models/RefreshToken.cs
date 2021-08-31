using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Entities.Models
{
    [Table("RefreshToken")]
    public partial class RefreshToken
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Refreshable { get; set; }
        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public virtual User User { get; set; }
    }
}
