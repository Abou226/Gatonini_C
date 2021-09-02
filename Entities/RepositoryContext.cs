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

        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Quartier> Quartiers { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<GateauBase> GateauBases { get; set; }
        public DbSet<GateauFini> GateauFinis { get; set; }
        public DbSet<Stock_Base> Stock_Bases { get; set; }
        public DbSet<Stock_Produit> Stock_Produits { get; set; }
        public DbSet<Payement> Payements { get; set; }
        public DbSet<Filiale> Filiales { get; set; }
        public DbSet<Num_Vente> num_Ventes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<AchatIngredient> AchatIngredients { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<ExternalLogin> ExternalLogins { get; set; }
        public DbSet<UsageIngredient> UsageIngredients { get; set; }
        public DbSet<Mode_Payement> Mode_Payements { get; set; }
        public virtual DbSet<Gamme> Gammes { get; set; }
        public virtual DbSet<Marque> Marques { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<StkTemp> StkTemps { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        //public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<Taille> Tailles { get; set; }
        public virtual DbSet<TblAccessoire> TblAccessoires { get; set; }
        public virtual DbSet<TblAchat> TblAchats { get; set; }
        public virtual DbSet<TblArrivée> TblArrivées { get; set; }
        public virtual DbSet<TblArrivéePartenaire> TblArrivéePartenaires { get; set; }
        public virtual DbSet<TblArrivéeTemp> TblArrivéeTemps { get; set; }
        public virtual DbSet<TblArrivéeTempPartenaire> TblArrivéeTempPartenaires { get; set; }
        public virtual DbSet<TblAvariePartenaire> TblAvariePartenaires { get; set; }
        public virtual DbSet<TblAvariePartenaireTemp> TblAvariePartenaireTemps { get; set; }
        public virtual DbSet<TblBon> TblBons { get; set; }
        public virtual DbSet<TblBonPartenaire> TblBonPartenaires { get; set; }
        public virtual DbSet<TblCatégorie> TblCatégories { get; set; }
        public virtual DbSet<TblCatégorieGadget> TblCatégorieGadgets { get; set; }
        public virtual DbSet<TblCatégoriePartenaire> TblCatégoriePartenaires { get; set; }
        public virtual DbSet<TblClient> TblClients { get; set; }
        public virtual DbSet<TblClient1> TblClients1 { get; set; }
        public virtual DbSet<TblClientPartenaire> TblClientPartenaires { get; set; }
        public virtual DbSet<TblCommande> TblCommandes { get; set; }
        public virtual DbSet<TblCommandePartenaire> TblCommandePartenaires { get; set; }
        public virtual DbSet<TblCommandeTempPartenaire> TblCommandeTempPartenaires { get; set; }
        public virtual DbSet<TblCompteComptable> TblCompteComptables { get; set; }
        public virtual DbSet<TblDepense> TblDepenses { get; set; }
        public virtual DbSet<TblDetachement> TblDetachements { get; set; }
        public virtual DbSet<TblElement> TblElements { get; set; }
        public virtual DbSet<TblEntité> TblEntités { get; set; }
        public virtual DbSet<TblEntreprise> TblEntreprises { get; set; }
        public virtual DbSet<TblFichierGestion> TblFichierGestions { get; set; }
        public virtual DbSet<TblFileLocation> TblFileLocations { get; set; }
        public virtual DbSet<TblFilialePartenaire> TblFilialePartenaires { get; set; }
        public virtual DbSet<TblFormuleMesureVente> TblFormuleMesureVentes { get; set; }
        public virtual DbSet<TblFormuleMesureVentePartenaire> TblFormuleMesureVentePartenaires { get; set; }
        public virtual DbSet<TblFournisseur> TblFournisseurs { get; set; }
        public virtual DbSet<TblGadget> TblGadgets { get; set; }
        public virtual DbSet<TblGarnissage> TblGarnissages { get; set; }
        public virtual DbSet<TblGateau> TblGateaus { get; set; }
        public virtual DbSet<TblGateauBase> TblGateauBases { get; set; }
        public virtual DbSet<TblGateauBaseTemp> TblGateauBaseTemps { get; set; }
        public virtual DbSet<TblGateauClient> TblGateauClients { get; set; }
        public virtual DbSet<TblGateauFiniTemp> TblGateauFiniTemps { get; set; }
        public virtual DbSet<TblGrosGateau> TblGrosGateaus { get; set; }
        public virtual DbSet<TblIntitulé> TblIntitulés { get; set; }
        public virtual DbSet<TblInventaire> TblInventaires { get; set; }
        public virtual DbSet<TblJournalComptable> TblJournalComptables { get; set; }
        public virtual DbSet<TblJournalComptableTest> TblJournalComptableTests { get; set; }
        public virtual DbSet<TblLikesGateau> TblLikesGateaus { get; set; }
        public virtual DbSet<TblListFournisseur> TblListFournisseurs { get; set; }
        public virtual DbSet<TblListGateau> TblListGateaus { get; set; }
        public virtual DbSet<TblListJournaux> TblListJournauxes { get; set; }
        public virtual DbSet<TblListProduit> TblListProduits { get; set; }
        public virtual DbSet<TblListValidationStock> TblListValidationStocks { get; set; }
        public virtual DbSet<TblLivraison> TblLivraisons { get; set; }
        public virtual DbSet<TblLivraisonPartenaire> TblLivraisonPartenaires { get; set; }
        public virtual DbSet<TblLivraisonPartenaireExpress> TblLivraisonPartenaireExpresses { get; set; }
        public virtual DbSet<TblLivreur> TblLivreurs { get; set; }
        public virtual DbSet<TblLivreurPartenaire> TblLivreurPartenaires { get; set; }
        public virtual DbSet<TblMarque> TblMarques { get; set; }
        public virtual DbSet<TblMarquePartenaire> TblMarquePartenaires { get; set; }
        public virtual DbSet<TblMelange> TblMelanges { get; set; }
        public virtual DbSet<TblMesureVente> TblMesureVentes { get; set; }
        public virtual DbSet<TblMesureVentePartenaire> TblMesureVentePartenaires { get; set; }
        public virtual DbSet<TblMode_PayementPartenaire> TblMode_PayementPartenaires { get; set; }
        public virtual DbSet<TblModel> TblModels { get; set; }
        public virtual DbSet<TblNum_Achat> TblNum_Achats { get; set; }
        public virtual DbSet<TblNum_AchatPartenaire> TblNum_AchatPartenaires { get; set; }
        public virtual DbSet<TblNumAvariePartenaire> TblNumAvariePartenaires { get; set; }
        public virtual DbSet<TblNum_Cmd> TblNum_Cmds { get; set; }
        public virtual DbSet<TblNum_CmdPartenaire> TblNum_CmdPartenaires { get; set; }
        public virtual DbSet<TblNumPayementPartenaire> TblNumPayementPartenaires { get; set; }
        public virtual DbSet<TblNum_Transfère> TblNum_Transfères { get; set; }
        public virtual DbSet<TblNum_TransfèrePartenaire> TblNum_TransfèrePartenaires { get; set; }
        public virtual DbSet<TblNum_Vente> TblNum_Ventes { get; set; }
        public virtual DbSet<TblNum_VentePartenaire> TblNum_VentePartenaires { get; set; }
        public virtual DbSet<TblNum_VentePartenairesExpress> TblNum_VentePartenairesExpresses { get; set; }
        public virtual DbSet<TblOperationDefaultPartenaire> TblOperationDefaultPartenaires { get; set; }
        public virtual DbSet<TblPartenaire> TblPartenaires { get; set; }
        public virtual DbSet<TblPartenairesFiliale> TblPartenairesFiliales { get; set; }
        public virtual DbSet<TblPayement> TblPayements { get; set; }
        public virtual DbSet<TblPayementPartenaire> TblPayementPartenaires { get; set; }
        public virtual DbSet<TblPetitGateau> TblPetitGateaus { get; set; }
        public virtual DbSet<TblPlaningGateau> TblPlaningGateaus { get; set; }
        public virtual DbSet<TblPreparé> TblPreparés { get; set; }
        public virtual DbSet<TblProduit> TblProduits { get; set; }
        public virtual DbSet<TblProduitsPartenaire> TblProduitsPartenaires { get; set; }
        public virtual DbSet<TblProtuitAgro> TblProtuitAgros { get; set; }
        public virtual DbSet<TblRedévancePartenaire> TblRedévancePartenaires { get; set; }
        public virtual DbSet<TblRegistreGateau> TblRegistreGateaus { get; set; }
        public virtual DbSet<TblRemise> TblRemises { get; set; }
        public virtual DbSet<TblRepartition> TblRepartitions { get; set; }
        public virtual DbSet<TblRepartitionGadget> TblRepartitionGadgets { get; set; }
        public virtual DbSet<TblRepartitionGadgetTemp> TblRepartitionGadgetTemps { get; set; }
        public virtual DbSet<TblRepartitionPartenaire> TblRepartitionPartenaires { get; set; }
        public virtual DbSet<TblRepartitionPartenaireTemp> TblRepartitionPartenaireTemps { get; set; }
        public virtual DbSet<TblRepartitionsTemp> TblRepartitionsTemps { get; set; }
        public virtual DbSet<TblRequetteGateauBase> TblRequetteGateauBases { get; set; }
        public virtual DbSet<TblRequetteIngredient> TblRequetteIngredients { get; set; }
        public virtual DbSet<TblReservationPartenaire> TblReservationPartenaires { get; set; }
        public virtual DbSet<TblReservationPartenaireTemp> TblReservationPartenaireTemps { get; set; }
        public virtual DbSet<TblResteIngredient> TblResteIngredients { get; set; }
        public virtual DbSet<TblRetourClient> TblRetourClients { get; set; }
        public virtual DbSet<TblStockFiniRavitaillement> TblStockFiniRavitaillements { get; set; }
        public virtual DbSet<TblStockGadget> TblStockGadgets { get; set; }
        public virtual DbSet<TblStockGateau> TblStockGateaus { get; set; }
        public virtual DbSet<TblStockGateauBase> TblStockGateauBases { get; set; }
        public virtual DbSet<TblStockPartenairesFiliale> TblStockPartenairesFiliales { get; set; }
        public virtual DbSet<TblSynchro> TblSynchros { get; set; }
        public virtual DbSet<TblSynchroDate> TblSynchroDates { get; set; }
        public virtual DbSet<TblSynchroStat> TblSynchroStats { get; set; }
        public virtual DbSet<TblTaille> TblTailles { get; set; }
        public virtual DbSet<TblTaillePartenaire> TblTaillePartenaires { get; set; }
        public virtual DbSet<TblTempAchat> TblTempAchats { get; set; }
        public virtual DbSet<TblTempCommande> TblTempCommandes { get; set; }
        public virtual DbSet<TblTempReserv> TblTempReservs { get; set; }
        public virtual DbSet<TblTempUsage> TblTempUsages { get; set; }
        public virtual DbSet<TblTran> TblTrans { get; set; }
        public virtual DbSet<TblUsage> TblUsages { get; set; }
        public virtual DbSet<TblUsageGadget> TblUsageGadgets { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUsersPartenaire> TblUsersPartenaires { get; set; }
        public virtual DbSet<TblVente> TblVentes { get; set; }
        public virtual DbSet<TblVentePartenaire> TblVentePartenaires { get; set; }
        public virtual DbSet<TblVentePartenaireTemp> TblVentePartenaireTemps { get; set; }
        public virtual DbSet<TblVenteTemp> TblVenteTemps { get; set; }
        public virtual DbSet<TempReservation> TempReservations { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

    }
}
