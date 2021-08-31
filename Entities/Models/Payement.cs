using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Payement")]
    public class Payement
    {
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Montant { get; set; }
        public string Reference { get; set; }
        public string Num_Opération { get; set; }

        [ForeignKey(nameof(Mode_Payement))]
        public Guid? Mode_PayementId { get; set; }
        public Mode_Payement Mode_Payement { get; set; }
        public string Type { get; set; }
        public string Nature { get; set; }
        public DateTime Date { get; set; }
        public DateTime DatePayement { get; set; }
        public Guid? UserId { get; set; }
    }
}
