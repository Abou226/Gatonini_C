using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblPayementPartenaire
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string NumClient { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DatePayement { get; set; }
        public string Auteur { get; set; }
        public decimal? Montant { get; set; }
        public string ModePayement { get; set; }
        public string Commentaire { get; set; }
        public string NumOpération { get; set; }
        public string Matricule { get; set; }
        public string Type { get; set; }
        public decimal? Réduction { get; set; }
        public string Raison { get; set; }
        public string CompteTier { get; set; }
        public string Nature { get; set; }
        public DateTime? DateEcheance { get; set; }
        public string Reference { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
    }
}
