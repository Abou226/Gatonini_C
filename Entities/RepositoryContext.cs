using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<ExternalLogin> ExternalLogins { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Gamme> Gammes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<GrosGateau> GrosGateaus { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Quartier> Quartiers { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Num_Vente> Num_Ventes { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Payement> Payements { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<UsageIngredient> UsageIngredients { get; set; }
        public DbSet<Stock_Base> Stock_Bases { get; set; }
        public DbSet<Stock_Produit> Stock_Produits { get; set; }
        public DbSet<GateauBase> GateauBases { get; set; }
        public DbSet<GateauFini> GateauFinis { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Filiale> Filiales { get; set; }
        public DbSet<AchatIngredient> AchatIngredients { get; set; }

    }
}
