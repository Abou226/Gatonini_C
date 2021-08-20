using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblCompteComptable
    {
        public int Id { get; set; }
        public string Compte { get; set; }
        public string Catégorie { get; set; }
        public string NomCompte { get; set; }
        public DateTime? DateAjout { get; set; }
        public string Auteur { get; set; }
        public string Description { get; set; }
        public string CompteAux { get; set; }
        public string Type { get; set; }
        public string Préfix { get; set; }
    }
}
