using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_fichier_gestion")]
    public partial class TblFichierGestion
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Num_Opération { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public byte[] Fichier { get; set; }
        public string Nom_Fichier { get; set; }
    }
}
