using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class TblFichierGestion
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumOpération { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Auteur { get; set; }
        public byte[] Fichier { get; set; }
        public string NomFichier { get; set; }
    }
}
