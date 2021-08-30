using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("tbl_gros_gateau")]
    public class GrosGateau
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime Date_Ajout { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public string Auteur { get; set; }
        
        [StringLength(50, ErrorMessage = "La taille du code ne peut dépasser 50 characters")]
        public string Code { get; set; }
        public string FilePath { get; set; }

        [StringLength(50, ErrorMessage = "La taille de la categorie ne peut dépasser 50 characters")]
        public string Categorie { get; set; }
    }
}
