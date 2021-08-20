using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblLivraisonPartenaire
    {
        public int Id { get; set; }
        public int? Reference { get; set; }
        public string Gateau { get; set; }
        public string ContactClient { get; set; }
        public string NomClient { get; set; }
        public string AdresseLivraison { get; set; }
        public string Livreur { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string Auteur { get; set; }
        public DateTime? Date { get; set; }
        public string Entreprise { get; set; }
        public string Filiale { get; set; }
    }
}
