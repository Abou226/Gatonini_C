using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entities.Models
{
    public partial class GestionCommercialContext : DbContext
    {
        public GestionCommercialContext()
        {
        }

        public GestionCommercialContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Gamme> Gammes { get; set; }
        public virtual DbSet<Marque> Marques { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<StkTemp> StkTemps { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
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
        public virtual DbSet<TblModePayementPartenaire> TblModePayementPartenaires { get; set; }
        public virtual DbSet<TblModel> TblModels { get; set; }
        public virtual DbSet<TblNumAchat> TblNumAchats { get; set; }
        public virtual DbSet<TblNumAchatPartenaire> TblNumAchatPartenaires { get; set; }
        public virtual DbSet<TblNumAvariePartenaire> TblNumAvariePartenaires { get; set; }
        public virtual DbSet<TblNumCmd> TblNumCmds { get; set; }
        public virtual DbSet<TblNumCmdPartenaire> TblNumCmdPartenaires { get; set; }
        public virtual DbSet<TblNumPayementPartenaire> TblNumPayementPartenaires { get; set; }
        public virtual DbSet<TblNumTransfère> TblNumTransfères { get; set; }
        public virtual DbSet<TblNumTransfèrePartenaire> TblNumTransfèrePartenaires { get; set; }
        public virtual DbSet<TblNumVente> TblNumVentes { get; set; }
        public virtual DbSet<TblNumVentePartenaire> TblNumVentePartenaires { get; set; }
        public virtual DbSet<TblNumVentePartenairesExpress> TblNumVentePartenairesExpresses { get; set; }
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=3.238.202.175;DataBase=Gestion Commercial;Trusted_Connection=false;User ID=adming72;Password=adming72");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable("Categorie");

                entity.Property(e => e.CategorieId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(220);
            });

            modelBuilder.Entity<Gamme>(entity =>
            {
                entity.ToTable("Gamme");

                entity.HasIndex(e => e.CategorieId, "IX_Gamme_CategorieId");

                entity.HasIndex(e => e.MarqueId, "IX_Gamme_MarqueId");

                entity.HasIndex(e => e.StyleId, "IX_Gamme_StyleId");

                entity.Property(e => e.GammeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Categorie)
                    .WithMany(p => p.Gammes)
                    .HasForeignKey(d => d.CategorieId);

                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Gammes)
                    .HasForeignKey(d => d.MarqueId);

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.Gammes)
                    .HasForeignKey(d => d.StyleId);
            });

            modelBuilder.Entity<Marque>(entity =>
            {
                entity.ToTable("Marque");

                entity.Property(e => e.MarqueId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.Property(e => e.ModelId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Url).HasMaxLength(400);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("RefreshToken");

                entity.HasIndex(e => e.AuteurId, "IX_RefreshToken_AuteurId");

                entity.HasIndex(e => e.UserId, "IX_RefreshToken_UserId");

                entity.Property(e => e.RefreshTokenId).ValueGeneratedNever();

                entity.Property(e => e.DateOfCreation).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Refreshable)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Token).IsRequired();

                entity.HasOne(d => d.Auteur)
                    .WithMany(p => p.RefreshTokenAuteurs)
                    .HasForeignKey(d => d.AuteurId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshTokenUsers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.Reference);

                entity.ToTable("Reservation");

                entity.HasIndex(e => e.UserId, "IX_Reservation_UserId");

                entity.Property(e => e.Reference).ValueGeneratedNever();

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adresse_Livraison");

                entity.Property(e => e.Attribué)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuteurAnnulation)
                    .HasMaxLength(150)
                    .HasColumnName("Auteur_Annulation");

                entity.Property(e => e.AuteurModif)
                    .HasMaxLength(150)
                    .HasColumnName("Auteur_Modif");

                entity.Property(e => e.AuteurReception)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Reception");

                entity.Property(e => e.AuteurSortie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Sortie");

                entity.Property(e => e.AutreNumPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Autre_Num_Payement");

                entity.Property(e => e.Client)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livraison");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateAction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Action");

                entity.Property(e => e.DateAnnultation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Annultation");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.DateModification)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Modification");

                entity.Property(e => e.DatePayement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Payement");

                entity.Property(e => e.DateProduction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Production");

                entity.Property(e => e.DateSortie)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Sortie");

                entity.Property(e => e.DeptAuteur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Auteur");

                entity.Property(e => e.DescripInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Descrip_Info");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Detachement).HasMaxLength(50);

                entity.Property(e => e.Disponible).HasMaxLength(50);

                entity.Property(e => e.EchecLivr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Echec_Livr");

                entity.Property(e => e.FormeGateau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Forme_Gateau");

                entity.Property(e => e.Garnissage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GateauPour)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Gateau_Pour");

                entity.Property(e => e.GenreClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Genre_Client");

                entity.Property(e => e.HeureLivraison)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Heure_Livraison");

                entity.Property(e => e.IdClient)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Client");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Livraison)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Livreur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MentionSurGateau)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mention_sur_gateau");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Nombre).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Num2Client)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num2_Client");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumCmd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Cmd");

                entity.Property(e => e.Part).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Payement)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Payée)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RefPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Payement");

                entity.Property(e => e.RefSarali)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Sarali");

                entity.Property(e => e.ReservBoutique)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reserv_Boutique");

                entity.Property(e => e.Reste).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Retour)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReçuLogistique)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Reçu_Logistique");

                entity.Property(e => e.SituationPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Situation_Payement");

                entity.Property(e => e.SommePayée)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Somme_Payée");

                entity.Property(e => e.SortieCuisine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sortie_Cuisine");

                entity.Property(e => e.TempLivraison)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Temp_Livraison");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidationPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Validation_Payement");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<StkTemp>(entity =>
            {
                entity.ToTable("stk_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdProduit).HasColumnName("Id_Produit");

                entity.Property(e => e.Ingredient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Unité)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.ToTable("Style");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Url).HasMaxLength(400);
            });

            modelBuilder.Entity<Sysdiagram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Taille>(entity =>
            {
                entity.ToTable("Taille");

                entity.Property(e => e.TailleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TblAccessoire>(entity =>
            {
                entity.ToTable("tbl_accessoire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAchat>(entity =>
            {
                entity.ToTable("tbl_achat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Crédit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Débit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumFacture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Facture");

                entity.Property(e => e.Qreel).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RefPièces)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Pièces");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblArrivée>(entity =>
            {
                entity.ToTable("tbl_arrivée");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(150)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.DateArrivée)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Arrivée");

                entity.Property(e => e.Détachement).HasMaxLength(50);

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumAchat)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Achat");

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblArrivéePartenaire>(entity =>
            {
                entity.ToTable("tbl_arrivée_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.DateAction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Action");

                entity.Property(e => e.DateArrivée)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Arrivée");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Fournisseur).HasMaxLength(50);

                entity.Property(e => e.IdFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Fournisseur");

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.NumAchat)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Achat");

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Unité");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblArrivéeTemp>(entity =>
            {
                entity.ToTable("tbl_arrivée_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(150)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.DateArrivée)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Arrivée");

                entity.Property(e => e.Détachement).HasMaxLength(50);

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblArrivéeTempPartenaire>(entity =>
            {
                entity.ToTable("tbl_arrivée_temp_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.DateArrivée)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Arrivée");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Fournisseur).HasMaxLength(50);

                entity.Property(e => e.IdFournisseur)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Fournisseur");

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAvariePartenaire>(entity =>
            {
                entity.ToTable("tbl_avarie_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);

                entity.Property(e => e.Validé).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAvariePartenaireTemp>(entity =>
            {
                entity.ToTable("tbl_avarie_partenaire_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);
            });

            modelBuilder.Entity<TblBon>(entity =>
            {
                entity.ToTable("tbl_bon");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");
            });

            modelBuilder.Entity<TblBonPartenaire>(entity =>
            {
                entity.ToTable("tbl_bon_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");
            });

            modelBuilder.Entity<TblCatégorie>(entity =>
            {
                entity.ToTable("tbl_catégorie");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");
            });

            modelBuilder.Entity<TblCatégorieGadget>(entity =>
            {
                entity.ToTable("tbl_catégorie_gadget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");
            });

            modelBuilder.Entity<TblCatégoriePartenaire>(entity =>
            {
                entity.ToTable("tbl_catégorie_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Entreprise).HasMaxLength(50);
            });

            modelBuilder.Entity<TblClient>(entity =>
            {
                entity.ToTable("tbl_client");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(50);

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Genre).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<TblClient1>(entity =>
            {
                entity.ToTable("tbl_clients");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotPasse)
                    .HasMaxLength(50)
                    .HasColumnName("Mot_Passe");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblClientPartenaire>(entity =>
            {
                entity.ToTable("tbl_client_partenaires");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(50);

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Genre).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCommande>(entity =>
            {
                entity.ToTable("tbl_commande");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCommandePartenaire>(entity =>
            {
                entity.ToTable("tbl_commande_partenaires");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(150);

                entity.Property(e => e.Annulée).HasMaxLength(50);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.ContactLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livraison");

                entity.Property(e => e.ContactLivreur)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livreur");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateAction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Action");

                entity.Property(e => e.DateAnnulation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Annulation");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.DateModification)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Modification");

                entity.Property(e => e.DatePayement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Payement");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Heure).HasMaxLength(50);

                entity.Property(e => e.IdAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Auteur");

                entity.Property(e => e.IdEntité)
                    .HasMaxLength(150)
                    .HasColumnName("Id_Entité");

                entity.Property(e => e.Livreur).HasMaxLength(150);

                entity.Property(e => e.Livrée).HasMaxLength(50);

                entity.Property(e => e.Mention).HasMaxLength(150);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumVente)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Vente");

                entity.Property(e => e.Payée).HasMaxLength(50);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReferencePayement)
                    .HasMaxLength(50)
                    .HasColumnName("Reference_Payement");
            });

            modelBuilder.Entity<TblCommandeTempPartenaire>(entity =>
            {
                entity.ToTable("tbl_commande_temp_partenaires");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(150);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.ContactLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livraison");

                entity.Property(e => e.ContactLivreur)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livreur");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Heure).HasMaxLength(50);

                entity.Property(e => e.IdAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Auteur");

                entity.Property(e => e.IdEntité)
                    .HasMaxLength(150)
                    .HasColumnName("Id_Entité");

                entity.Property(e => e.Livreur).HasMaxLength(150);

                entity.Property(e => e.Mention).HasMaxLength(150);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblCompteComptable>(entity =>
            {
                entity.ToTable("tbl_compte_comptable");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Compte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompteAux)
                    .HasMaxLength(50)
                    .HasColumnName("Compte_Aux");

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NomCompte)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Compte");

                entity.Property(e => e.Préfix).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepense>(entity =>
            {
                entity.ToTable("tbl_depenses");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Depenses)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCompte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Info_Compte");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblDetachement>(entity =>
            {
                entity.ToTable("tbl_detachement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(100);

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Siège).HasMaxLength(50);
            });

            modelBuilder.Entity<TblElement>(entity =>
            {
                entity.ToTable("tbl_elements");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valeur)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEntité>(entity =>
            {
                entity.ToTable("tbl_entité");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Nom).HasMaxLength(150);
            });

            modelBuilder.Entity<TblEntreprise>(entity =>
            {
                entity.ToTable("tbl_entreprise");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Couleur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pays)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Secteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slogan)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProduit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Type_Produit");

                entity.Property(e => e.Téléphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFichierGestion>(entity =>
            {
                entity.ToTable("tbl_fichier_gestion");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Nom).HasMaxLength(150);

                entity.Property(e => e.NomFichier)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_Fichier");

                entity.Property(e => e.NumOpération)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Num_Opération");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblFileLocation>(entity =>
            {
                entity.ToTable("tbl_FileLocation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FilePath).HasMaxLength(150);
            });

            modelBuilder.Entity<TblFilialePartenaire>(entity =>
            {
                entity.ToTable("tbl_filiale_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(100);

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Siège).HasMaxLength(50);
            });

            modelBuilder.Entity<TblFormuleMesureVente>(entity =>
            {
                entity.ToTable("tbl_formule_mesure_vente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Formule).HasMaxLength(50);

                entity.Property(e => e.Grand).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HyperLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Hyper Large");

                entity.Property(e => e.Large).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Moyen).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Petit).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblFormuleMesureVentePartenaire>(entity =>
            {
                entity.ToTable("tbl_formule_mesure_vente_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Formule).HasMaxLength(50);

                entity.Property(e => e.Grand).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HyperLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Hyper Large");

                entity.Property(e => e.Large).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Moyen).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Petit).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblFournisseur>(entity =>
            {
                entity.ToTable("tbl_fournisseurs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGadget>(entity =>
            {
                entity.ToTable("tbl_gadget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Marque).HasMaxLength(100);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NomFichier)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_Fichier");

                entity.Property(e => e.PrixGrand)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Grand");

                entity.Property(e => e.PrixHyperLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Hyper_Large");

                entity.Property(e => e.PrixLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Large");

                entity.Property(e => e.PrixMoyen)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Moyen");

                entity.Property(e => e.PrixPetit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Petit");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.StockMax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_max");

                entity.Property(e => e.StockMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_min");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGarnissage>(entity =>
            {
                entity.ToTable("tbl_garnissage");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("Prix_Unité");
            });

            modelBuilder.Entity<TblGateau>(entity =>
            {
                entity.ToTable("tbl_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AuteurReception)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Reception");

                entity.Property(e => e.AuteurSortie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Sortie");

                entity.Property(e => e.AutreForme)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Autre_Forme");

                entity.Property(e => e.Buste).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Coeur).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Reception");

                entity.Property(e => e.Gateau)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Heure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.QAutre)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Autre");

                entity.Property(e => e.QBuste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Buste");

                entity.Property(e => e.QCoeur)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Coeur");

                entity.Property(e => e.QRectangle)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Rectangle");

                entity.Property(e => e.QReçu)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Reçu");

                entity.Property(e => e.QRond)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Rond");

                entity.Property(e => e.QRondHaut)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_RondHaut");

                entity.Property(e => e.QUtilisé)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Utilisé");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rectangle).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rond).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RondHaut)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Rond_Haut");

                entity.Property(e => e.UAutreForme)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_AutreForme");

                entity.Property(e => e.UBuste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_Buste");

                entity.Property(e => e.UCoeur)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_Coeur");

                entity.Property(e => e.URectangle)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_Rectangle");

                entity.Property(e => e.URond)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_Rond");

                entity.Property(e => e.URondHaut)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("U_RondHaut");
            });

            modelBuilder.Entity<TblGateauBase>(entity =>
            {
                entity.ToTable("tbl_gateau_base");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(100)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detachement).HasMaxLength(150);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NbLancé)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Lancé");

                entity.Property(e => e.NbPart).HasColumnName("Nb_Part");
            });

            modelBuilder.Entity<TblGateauBaseTemp>(entity =>
            {
                entity.ToTable("tbl_gateau_base_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(100);

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(100)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateValidation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Validation");

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Qreel)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QReel");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblGateauClient>(entity =>
            {
                entity.ToTable("tbl_gateau_client");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.NbAvis).HasColumnName("Nb_Avis");

                entity.Property(e => e.NbCmd).HasColumnName("Nb_Cmd");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");
            });

            modelBuilder.Entity<TblGateauFiniTemp>(entity =>
            {
                entity.ToTable("tbl_gateau_fini_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(100);

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(100)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateValidation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Validation");

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Qreel)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QReel");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblGrosGateau>(entity =>
            {
                entity.ToTable("tbl_gros_gateau");

                entity.HasIndex(e => e.AuteurId, "IX_tbl_gros_gateau_AuteurId");

                entity.HasIndex(e => e.AuteurId, "IX_tbl_livraison_AuteurId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Categorie).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Filename).HasMaxLength(150);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuteurNavigation)
                    .WithMany(p => p.TblGrosGateaus)
                    .HasForeignKey(d => d.AuteurId);
            });

            modelBuilder.Entity<TblIntitulé>(entity =>
            {
                entity.ToTable("tbl_intitulé");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Intitulé)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInventaire>(entity =>
            {
                entity.ToTable("tbl_inventaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_max");

                entity.Property(e => e.StockMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_min");
            });

            modelBuilder.Entity<TblJournalComptable>(entity =>
            {
                entity.ToTable("tbl_journal_comptable");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cloturé)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Compte).HasMaxLength(50);

                entity.Property(e => e.CompteTier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compte_Tier");

                entity.Property(e => e.Crédit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Enregistrement");

                entity.Property(e => e.Débit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NFacture)
                    .HasMaxLength(50)
                    .HasColumnName("N_Facture");

                entity.Property(e => e.NomFichier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Fichier");

                entity.Property(e => e.RefPayement)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Payement");

                entity.Property(e => e.RefPièces)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Pièces");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Validé).HasMaxLength(50);
            });

            modelBuilder.Entity<TblJournalComptableTest>(entity =>
            {
                entity.ToTable("tbl_journal_comptable_test");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Compte).HasMaxLength(50);

                entity.Property(e => e.CompteTier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compte_Tier");

                entity.Property(e => e.Crédit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Enregistrement");

                entity.Property(e => e.Débit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NFacture)
                    .HasMaxLength(50)
                    .HasColumnName("N_Facture");

                entity.Property(e => e.NomFichier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Fichier");

                entity.Property(e => e.RefPayement)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Payement");

                entity.Property(e => e.RefPièces)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Pièces");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Validé).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLikesGateau>(entity =>
            {
                entity.ToTable("tbl_likes_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.IdProduit).HasColumnName("Id_Produit");
            });

            modelBuilder.Entity<TblListFournisseur>(entity =>
            {
                entity.ToTable("tbl_list_fournisseur");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Pays).HasMaxLength(50);

                entity.Property(e => e.TailleImage)
                    .HasMaxLength(50)
                    .HasColumnName("Taille_Image");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<TblListGateau>(entity =>
            {
                entity.ToTable("tbl_list_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutreForme).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Buste).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Coeur).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.NbPart)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rectangle).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rond).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RondHaut).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StockMax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_max");

                entity.Property(e => e.StockMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_min");
            });

            modelBuilder.Entity<TblListJournaux>(entity =>
            {
                entity.ToTable("tbl_list_journaux");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(100);

                entity.Property(e => e.Compte).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Nom).HasMaxLength(150);

                entity.Property(e => e.Prefix).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblListProduit>(entity =>
            {
                entity.ToTable("tbl_list_produit");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutreForme).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Buste).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Catégorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Coeur).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.NbPart)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rectangle).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rond).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RondHaut).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StockMax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_max");

                entity.Property(e => e.StockMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_min");
            });

            modelBuilder.Entity<TblListValidationStock>(entity =>
            {
                entity.ToTable("tbl_list_validation_stock");

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");
            });

            modelBuilder.Entity<TblLivraison>(entity =>
            {
                entity.ToTable("tbl_livraison");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Adresse_Livraison");

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Gateau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Livreur)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NomClient)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Client");

                entity.HasOne(d => d.AuteurNavigation)
                    .WithMany(p => p.TblLivraisons)
                    .HasForeignKey(d => d.AuteurId);
            });

            modelBuilder.Entity<TblLivraisonPartenaire>(entity =>
            {
                entity.ToTable("tbl_livraison_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Adresse_Livraison");

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Livreur)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NomClient)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Client");
            });

            modelBuilder.Entity<TblLivraisonPartenaireExpress>(entity =>
            {
                entity.ToTable("tbl_livraison_partenaire_express");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Adresse_Livraison");

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Entité).HasMaxLength(50);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Livreur)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NomClient)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Client");
            });

            modelBuilder.Entity<TblLivreur>(entity =>
            {
                entity.ToTable("tbl_livreur");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLivreurPartenaire>(entity =>
            {
                entity.ToTable("tbl_livreur_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Entreprise)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMarque>(entity =>
            {
                entity.ToTable("tbl_marque");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Marque).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMarquePartenaire>(entity =>
            {
                entity.ToTable("tbl_marque_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Marque).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMelange>(entity =>
            {
                entity.ToTable("tbl_melange");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Model)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");
            });

            modelBuilder.Entity<TblMesureVente>(entity =>
            {
                entity.ToTable("tbl_mesure_vente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Default).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMesureVentePartenaire>(entity =>
            {
                entity.ToTable("tbl_mesure_vente_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Default).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblModePayementPartenaire>(entity =>
            {
                entity.ToTable("tbl_mode_payement_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Defaut).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Simpa).HasMaxLength(50);
            });

            modelBuilder.Entity<TblModel>(entity =>
            {
                entity.ToTable("tbl_model");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Model)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("Prix_Unité");
            });

            modelBuilder.Entity<TblNumAchat>(entity =>
            {
                entity.ToTable("tbl_num_achat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NumAchat)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Achat");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumAchatPartenaire>(entity =>
            {
                entity.ToTable("tbl_num_achat_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NumAchat)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Achat");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumAvariePartenaire>(entity =>
            {
                entity.ToTable("tbl_num_avarie_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumCmd>(entity =>
            {
                entity.ToTable("tbl_num_cmd");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNumCmdPartenaire>(entity =>
            {
                entity.ToTable("tbl_num_cmd_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNumPayementPartenaire>(entity =>
            {
                entity.ToTable("tbl_num_payement_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumTransfère>(entity =>
            {
                entity.ToTable("tbl_num_transfère");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumTransfèrePartenaire>(entity =>
            {
                entity.ToTable("tbl_num_transfère_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumVente>(entity =>
            {
                entity.ToTable("tbl_num_vente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumVentePartenaire>(entity =>
            {
                entity.ToTable("tbl_num_vente_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumVentePartenairesExpress>(entity =>
            {
                entity.ToTable("tbl_num_vente_partenaires_express");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Order).HasMaxLength(50);
            });

            modelBuilder.Entity<TblOperationDefaultPartenaire>(entity =>
            {
                entity.ToTable("tbl_operation_default_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Default).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPartenaire>(entity =>
            {
                entity.ToTable("tbl_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(50);

                entity.Property(e => e.Contact1).HasMaxLength(50);

                entity.Property(e => e.Contact2).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.NomSocial)
                    .HasMaxLength(50)
                    .HasColumnName("Nom Social");

                entity.Property(e => e.Pays)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPartenairesFiliale>(entity =>
            {
                entity.ToTable("tbl_partenaires_filiale");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart).HasColumnName("Nb_Part");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblPayement>(entity =>
            {
                entity.ToTable("tbl_payement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Client");

                entity.Property(e => e.DatePayement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Payement");

                entity.Property(e => e.IdTier)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Tier");

                entity.Property(e => e.ModePayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mode_Payement");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NbGateau).HasColumnName("Nb_Gateau");

                entity.Property(e => e.NumCmd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Num_Cmd");

                entity.Property(e => e.Raison).HasMaxLength(50);

                entity.Property(e => e.RefGateau)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Gateau");

                entity.Property(e => e.RefPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Payement");

                entity.Property(e => e.RefSarali)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Sarali");

                entity.Property(e => e.Réduction).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPayementPartenaire>(entity =>
            {
                entity.ToTable("tbl_payement_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Client).HasMaxLength(50);

                entity.Property(e => e.Commentaire).HasMaxLength(150);

                entity.Property(e => e.CompteTier)
                    .HasMaxLength(50)
                    .HasColumnName("Compte Tier");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateEcheance)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Echeance");

                entity.Property(e => e.DatePayement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Payement");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.Matricule).HasMaxLength(50);

                entity.Property(e => e.ModePayement)
                    .HasMaxLength(50)
                    .HasColumnName("Mode_Payement");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nature).HasMaxLength(50);

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumOpération)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Opération");

                entity.Property(e => e.Raison).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Réduction).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPetitGateau>(entity =>
            {
                entity.ToTable("tbl_petit_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlaningGateau>(entity =>
            {
                entity.ToTable("tbl_planing_gateau");

                entity.HasIndex(e => e.GammeId, "IX_tbl_planing_gateau_GammeId");

                entity.HasIndex(e => e.ModelId, "IX_tbl_planing_gateau_ModelId");

                entity.HasIndex(e => e.TailleId, "IX_tbl_planing_gateau_TailleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Annulée)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Assignation).HasMaxLength(50);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuteurAnnulation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Annulation");

                entity.Property(e => e.AuteurReception)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Reception");

                entity.Property(e => e.AuteurRequette)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Requette");

                entity.Property(e => e.AuteurSortie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Sortie");

                entity.Property(e => e.BusqueFini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Busque_Fini");

                entity.Property(e => e.CoeurFini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Coeur_Fini");

                entity.Property(e => e.DateExRequette)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_ExRequette");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.DateReception)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Reception");

                entity.Property(e => e.DateRequette)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Requette");

                entity.Property(e => e.DateSortie)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Sortie");

                entity.Property(e => e.Forme)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Heure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NbCompter)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Compter");

                entity.Property(e => e.NbFinition)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Finition");

                entity.Property(e => e.NbPart)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NbRecueilli)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Recueilli");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceptionConfirmé)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reception_Confirmé");

                entity.Property(e => e.RectangleFini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Rectangle_Fini");

                entity.Property(e => e.RhautFini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RHaut_Fini");

                entity.Property(e => e.RondFini)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Rond_Fini");

                entity.Property(e => e.UseFinition)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Use_Finition");

                entity.HasOne(d => d.Gamme)
                    .WithMany(p => p.TblPlaningGateaus)
                    .HasForeignKey(d => d.GammeId);

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.TblPlaningGateaus)
                    .HasForeignKey(d => d.ModelId);

                entity.HasOne(d => d.Taille)
                    .WithMany(p => p.TblPlaningGateaus)
                    .HasForeignKey(d => d.TailleId);
            });

            modelBuilder.Entity<TblPreparé>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("tbl_preparé");

                entity.Property(e => e.Ref).ValueGeneratedNever();

                entity.Property(e => e.AuteurEnregistrement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Enregistrement");

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSortie)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Sortie");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mention)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblProduit>(entity =>
            {
                entity.ToTable("tbl_produits");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_max");

                entity.Property(e => e.StockMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Stock_min");

                entity.Property(e => e.Unité)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProduitsPartenaire>(entity =>
            {
                entity.ToTable("tbl_produits_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.DeptAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Auteur");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.FormuleStockage).HasColumnName("Formule_Stockage");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.NomImage)
                    .HasMaxLength(100)
                    .HasColumnName("Nom_Image");

                entity.Property(e => e.PrixAchat)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Achat");

                entity.Property(e => e.PrixGrand)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Grand");

                entity.Property(e => e.PrixGrandGrossiste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Grand_Grossiste");

                entity.Property(e => e.PrixHyperLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Hyper_Large");

                entity.Property(e => e.PrixHyperLargeGrossiste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Hyper_Large_Grossiste");

                entity.Property(e => e.PrixLarge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Large");

                entity.Property(e => e.PrixLargeGrossiste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Large_Grossiste");

                entity.Property(e => e.PrixMoyen)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Moyen");

                entity.Property(e => e.PrixMoyenGrossiste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Moyen_Grossiste");

                entity.Property(e => e.PrixPetit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Petit");

                entity.Property(e => e.PrixPetitGrossiste)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Petit_Grossiste");

                entity.Property(e => e.StockMax).HasColumnName("Stock_max");

                entity.Property(e => e.StockMin).HasColumnName("Stock_min");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblProtuitAgro>(entity =>
            {
                entity.ToTable("tbl_protuit_agro");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRedévancePartenaire>(entity =>
            {
                entity.ToTable("tbl_redévance_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Redéveur).HasMaxLength(150);

                entity.Property(e => e.Rédevant).HasMaxLength(150);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegistreGateau>(entity =>
            {
                entity.ToTable("tbl_registre_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodeBarre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");
            });

            modelBuilder.Entity<TblRemise>(entity =>
            {
                entity.ToTable("tbl_remise");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumCmd)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Cmd");
            });

            modelBuilder.Entity<TblRepartition>(entity =>
            {
                entity.ToTable("tbl_repartitions");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);

                entity.Property(e => e.Validée).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRepartitionGadget>(entity =>
            {
                entity.ToTable("tbl_repartition_gadget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Marque).HasMaxLength(50);

                entity.Property(e => e.NumTranfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Tranfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRepartitionGadgetTemp>(entity =>
            {
                entity.ToTable("tbl_repartition_gadget_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Marque).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRepartitionPartenaire>(entity =>
            {
                entity.ToTable("tbl_repartition_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);
            });

            modelBuilder.Entity<TblRepartitionPartenaireTemp>(entity =>
            {
                entity.ToTable("tbl_repartition_partenaire_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);
            });

            modelBuilder.Entity<TblRepartitionsTemp>(entity =>
            {
                entity.ToTable("tbl_repartitions_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.NumTransfère)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Transfère");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Source).HasMaxLength(150);
            });

            modelBuilder.Entity<TblRequetteGateauBase>(entity =>
            {
                entity.ToTable("tbl_requette_gateau_base");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuteurRequette)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Requette");

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateValidation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Validation");

                entity.Property(e => e.Forme)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.QUtilisé)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Utilisé");

                entity.Property(e => e.Qreel).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblRequetteIngredient>(entity =>
            {
                entity.ToTable("tbl_requette_ingredient");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active).HasMaxLength(50);

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(50)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateValidation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Validation");

                entity.Property(e => e.Ingredient).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.Qreel)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QReel");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Reference).HasMaxLength(50);
            });

            modelBuilder.Entity<TblReservationPartenaire>(entity =>
            {
                entity.ToTable("tbl_reservation_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(150);

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Commande).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Disponible).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.IdLivreur).HasColumnName("Id_Livreur");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Livreur).HasMaxLength(50);

                entity.Property(e => e.Livré).HasMaxLength(50);

                entity.Property(e => e.Mention).HasMaxLength(150);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Livraison");

                entity.Property(e => e.NumOperation)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Operation");

                entity.Property(e => e.Partenaire).HasMaxLength(50);

                entity.Property(e => e.Payée).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Situation).HasMaxLength(50);

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.TailleImage)
                    .HasMaxLength(50)
                    .HasColumnName("Taille_Image");

                entity.Property(e => e.TarifLivraison)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Tarif Livraison");

                entity.Property(e => e.TypeProduit)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Produit");
            });

            modelBuilder.Entity<TblReservationPartenaireTemp>(entity =>
            {
                entity.ToTable("tbl_reservation_partenaire_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adresse).HasMaxLength(150);

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Commande).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.Disponible).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.IdLivreur).HasColumnName("Id_Livreur");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Livreur).HasMaxLength(50);

                entity.Property(e => e.Livré).HasMaxLength(50);

                entity.Property(e => e.Mention).HasMaxLength(150);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Livraison");

                entity.Property(e => e.NumOperation)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Operation");

                entity.Property(e => e.Partenaire).HasMaxLength(50);

                entity.Property(e => e.Payée).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.TailleImage)
                    .HasMaxLength(50)
                    .HasColumnName("Taille_Image");

                entity.Property(e => e.TarifLivraison)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Tarif Livraison");

                entity.Property(e => e.TypeProduit)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Produit");
            });

            modelBuilder.Entity<TblResteIngredient>(entity =>
            {
                entity.ToTable("tbl_reste_ingredient");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Ingredient).HasMaxLength(50);

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.NomFichier)
                    .HasMaxLength(150)
                    .HasColumnName("Nom_Fichier");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblRetourClient>(entity =>
            {
                entity.ToTable("tbl_retour_client");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AuteurRetour)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Retour");

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Livraison).IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NbCmd).HasColumnName("Nb_Cmd");

                entity.Property(e => e.NumCmd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Cmd");

                entity.Property(e => e.Produit).IsUnicode(false);

                entity.Property(e => e.Reception).IsUnicode(false);

                entity.Property(e => e.Suggestion).IsUnicode(false);
            });

            modelBuilder.Entity<TblStockFiniRavitaillement>(entity =>
            {
                entity.ToTable("tbl_stock_fini_ravitaillement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(100);

                entity.Property(e => e.AuteurValidation)
                    .HasMaxLength(150)
                    .HasColumnName("Auteur_Validation");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detachement).HasMaxLength(150);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbLancé)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Nb_Lancé");

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblStockGadget>(entity =>
            {
                entity.ToTable("tbl_stock_gadget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Détachement).HasMaxLength(50);

                entity.Property(e => e.Marque).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblStockGateau>(entity =>
            {
                entity.ToTable("tbl_stock_gateau");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodeBarre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Detachement).HasMaxLength(150);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblStockGateauBase>(entity =>
            {
                entity.ToTable("tbl_stock_gateau_base");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Detachement).HasMaxLength(150);

                entity.Property(e => e.Forme).HasMaxLength(50);

                entity.Property(e => e.Gateau).HasMaxLength(50);

                entity.Property(e => e.NbPart)
                    .HasMaxLength(50)
                    .HasColumnName("Nb_Part");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblStockPartenairesFiliale>(entity =>
            {
                entity.ToTable("tbl_stock_partenaires_filiale");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prix).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSynchro>(entity =>
            {
                entity.ToTable("tbl_synchro");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GateauBase).HasColumnName("Gateau_Base");
            });

            modelBuilder.Entity<TblSynchroDate>(entity =>
            {
                entity.ToTable("tbl_synchro_date");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Production).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSynchroStat>(entity =>
            {
                entity.ToTable("tbl_synchro_stats");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StatsAchat).HasColumnName("Stats_Achat");

                entity.Property(e => e.StatsStock).HasColumnName("Stats_Stock");

                entity.Property(e => e.StatsVente).HasColumnName("Stats_Vente");
            });

            modelBuilder.Entity<TblTaille>(entity =>
            {
                entity.ToTable("tbl_taille");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTaillePartenaire>(entity =>
            {
                entity.ToTable("tbl_taille_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Taille).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTempAchat>(entity =>
            {
                entity.ToTable("tbl_temp_achat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.CompteC)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compte_C");

                entity.Property(e => e.CompteD)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Compte_D");

                entity.Property(e => e.Crédit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Débit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumFacture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Facture");

                entity.Property(e => e.Qreel).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RefPièces)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Pièces");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempCommande>(entity =>
            {
                entity.ToTable("tbl_temp_commande");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BonCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bon_Commande");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Fournisseur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempReserv>(entity =>
            {
                entity.HasKey(e => e.ReserId);

                entity.ToTable("tbl_tempReserv");

                entity.HasIndex(e => e.AuteurId, "IX_tbl_tempReserv_AuteurId");

                entity.Property(e => e.ReserId).ValueGeneratedNever();

                entity.Property(e => e.Gateau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Part).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 1)");

                entity.HasOne(d => d.Auteur)
                    .WithMany(p => p.TblTempReservs)
                    .HasForeignKey(d => d.AuteurId);
            });

            modelBuilder.Entity<TblTempUsage>(entity =>
            {
                entity.ToTable("tbl_temp_usage");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EffectuéePar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Effectuée_Par");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unité)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTran>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("tbl_trans");

                entity.Property(e => e.TransId).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NbReserv).HasColumnName("Nb_Reserv");

                entity.Property(e => e.Part).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Payement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Reste).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.TotalEncaissé)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("Total_Encaissé");
            });

            modelBuilder.Entity<TblUsage>(entity =>
            {
                entity.ToTable("tbl_Usage");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EffectuéePar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Effectuée_Par");

                entity.Property(e => e.Nom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unité)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsageGadget>(entity =>
            {
                entity.ToTable("tbl_usage_gadget");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_Users");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthComptabilité)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Comptabilité");

                entity.Property(e => e.AuthCuisine)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Cuisine");

                entity.Property(e => e.AuthGestion)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Gestion");

                entity.Property(e => e.AuthLogistique)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Logistique");

                entity.Property(e => e.AuthReservation)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Reservation");

                entity.Property(e => e.AuthStatsDashboard)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Stats_Dashboard");

                entity.Property(e => e.AuthStock)
                    .HasMaxLength(50)
                    .HasColumnName("Auth_Stock");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Departement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomComplet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Complet");

                entity.Property(e => e.Partenaire).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCompte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Type_Compte");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsersPartenaire>(entity =>
            {
                entity.ToTable("tbl_users_partenaires");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.DateAjout)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Ajout");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailConfirm)
                    .HasMaxLength(50)
                    .HasColumnName("Email_Confirm");

                entity.Property(e => e.Genre).HasMaxLength(50);

                entity.Property(e => e.IdEntité)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Entité");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(150);

                entity.Property(e => e.PicPath)
                    .HasMaxLength(150)
                    .HasColumnName("Pic_Path");

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.Telephone2Confirm)
                    .HasMaxLength(50)
                    .HasColumnName("Telephone2_Confirm");

                entity.Property(e => e.TelephoneConfirm)
                    .HasMaxLength(50)
                    .HasColumnName("Telephone_Confirm");

                entity.Property(e => e.TypeCompte)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Compte");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<TblVente>(entity =>
            {
                entity.ToTable("tbl_vente");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(150);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(150)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Détachement).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(150)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumVente)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Vente");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(150);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblVentePartenaire>(entity =>
            {
                entity.ToTable("tbl_vente_partenaire");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(50);

                entity.Property(e => e.AuteurPayement)
                    .HasMaxLength(150)
                    .HasColumnName("Auteur_Payement");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(50);

                entity.Property(e => e.DateAction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Action");

                entity.Property(e => e.DatePayement)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Payement");

                entity.Property(e => e.DateVente)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Vente");

                entity.Property(e => e.DeptAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Auteur");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.IdAuteur)
                    .HasMaxLength(150)
                    .HasColumnName("Id Auteur");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.IdEntité)
                    .HasMaxLength(150)
                    .HasColumnName("Id_Entité");

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.ModePayement)
                    .HasMaxLength(50)
                    .HasColumnName("Mode Payement");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nature).HasMaxLength(50);

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.NumVente)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Vente");

                entity.Property(e => e.Plateform).HasMaxLength(50);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(50);

                entity.Property(e => e.QUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Q_Unité");

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblVentePartenaireTemp>(entity =>
            {
                entity.ToTable("tbl_vente_partenaire_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Catégorie).HasMaxLength(50);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.DateVente)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Vente");

                entity.Property(e => e.DeptAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Auteur");

                entity.Property(e => e.Entreprise).HasMaxLength(50);

                entity.Property(e => e.Filiale).HasMaxLength(50);

                entity.Property(e => e.IdAuteur)
                    .HasMaxLength(50)
                    .HasColumnName("Id Auteur");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.IdEntité)
                    .HasMaxLength(150)
                    .HasColumnName("Id_Entité");

                entity.Property(e => e.Mesure).HasMaxLength(50);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nature).HasMaxLength(50);

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.Plateform).HasMaxLength(50);

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(50);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblVenteTemp>(entity =>
            {
                entity.ToTable("tbl_vente_temp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Auteur).HasMaxLength(150);

                entity.Property(e => e.Catégorie).HasMaxLength(150);

                entity.Property(e => e.Client).HasMaxLength(150);

                entity.Property(e => e.CodeBarre)
                    .HasMaxLength(150)
                    .HasColumnName("Code_Barre");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detachement).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(150)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.PrixUnité)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Prix_Unité");

                entity.Property(e => e.Produit).HasMaxLength(150);

                entity.Property(e => e.Quantité).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Taille).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Usage).HasMaxLength(50);
            });

            modelBuilder.Entity<TempReservation>(entity =>
            {
                entity.HasKey(e => e.Reference);

                entity.ToTable("temp_Reservation");

                entity.HasIndex(e => e.AuteurId, "IX_temp_Reservation_AuteurId");

                entity.Property(e => e.Reference).ValueGeneratedNever();

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adresse_Livraison");

                entity.Property(e => e.Attribué)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auteur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuteurReception)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Reception");

                entity.Property(e => e.AuteurSortie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Auteur_Sortie");

                entity.Property(e => e.AutreNumPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Autre_Num_Payement");

                entity.Property(e => e.Client)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLivraison)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Livraison");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Livraison");

                entity.Property(e => e.DateProduction)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Production");

                entity.Property(e => e.DateSortie)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Sortie");

                entity.Property(e => e.DeptAuteur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Auteur");

                entity.Property(e => e.DescripInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Descrip_Info");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EchecLivr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Echec_Livr");

                entity.Property(e => e.FormeGateau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Forme_Gateau");

                entity.Property(e => e.Garnissage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gateau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GateauPour)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Gateau_Pour");

                entity.Property(e => e.GenreClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Genre_Client");

                entity.Property(e => e.HeureLivraison)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Heure_Livraison");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Livraison)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Livreur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MentionSurGateau)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mention_sur_gateau");

                entity.Property(e => e.Montant).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Nombre).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Num2Client)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num2_Client");

                entity.Property(e => e.NumClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Num_Client");

                entity.Property(e => e.Part).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Payement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payée)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RefPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Payement");

                entity.Property(e => e.RefSarali)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Sarali");

                entity.Property(e => e.ReservBoutique)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reserv_Boutique");

                entity.Property(e => e.Reste).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReçuLogistique)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Reçu_Logistique");

                entity.Property(e => e.SortieCuisine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sortie_Cuisine");

                entity.Property(e => e.TempLivraison)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Temp_Livraison");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidationPayement)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Validation_Payement");

                entity.HasOne(d => d.AuteurNavigation)
                    .WithMany(p => p.TempReservations)
                    .HasForeignKey(d => d.AuteurId);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tests");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
