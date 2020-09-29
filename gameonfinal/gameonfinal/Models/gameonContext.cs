using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gameonfinal.Models
{
    public partial class gameonContext : DbContext
    {
        public gameonContext()
        {
        }

        public gameonContext(DbContextOptions<gameonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<GameType> GameType { get; set; }
        public virtual DbSet<Platforms> Platforms { get; set; }
        public virtual DbSet<PurchasedGames> PurchasedGames { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=gameon;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoCover)
                    .HasColumnName("photoCover")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlatFormId).HasColumnName("platFormId");

                entity.Property(e => e.Releasedate)
                    .HasColumnName("releasedate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Gametype)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GametypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__games__GametypeI__5070F446");

                entity.HasOne(d => d.PlatForm)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.PlatFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__games__platFormI__4F7CD00D");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.ToTable("gameType");

                entity.Property(e => e.GameType1)
                    .IsRequired()
                    .HasColumnName("GameType")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Platforms>(entity =>
            {
                entity.HasKey(e => e.PlatformId);

                entity.Property(e => e.PlatformId).HasColumnName("platformId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasedGames>(entity =>
            {
                entity.ToTable("purchasedGames");

                entity.Property(e => e.DatePurchased).HasColumnType("datetime");

                entity.Property(e => e.GameId).HasColumnName("gameId");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.PurchasedGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchased__gameI__5441852A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PurchasedGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__purchased__UserI__534D60F1");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.ToTable("reviews");

                entity.Property(e => e.GameId).HasColumnName("gameId");

                entity.Property(e => e.Review)
                    .IsRequired()
                    .HasColumnName("review")
                    .HasColumnType("text");

                entity.Property(e => e.Reviewdate)
                    .HasColumnName("reviewdate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reviews__gameId__5812160E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reviews__UserId__571DF1D5");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Dateaccountcreated).HasColumnType("datetime");

                entity.Property(e => e.Displayname)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photoPath")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserAccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
