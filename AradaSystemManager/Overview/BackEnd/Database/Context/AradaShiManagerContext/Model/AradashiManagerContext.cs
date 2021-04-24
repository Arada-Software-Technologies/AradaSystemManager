using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AradaSystemManager.Overview.BackEnd.Database.Context.AradaShiManagerContext.Model
{
    public partial class AradashiManagerContext : DbContext
    {
        public AradashiManagerContext()
        {
        }

        public AradashiManagerContext(DbContextOptions<AradashiManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysLog> SysLogs { get; set; }
        public virtual DbSet<SysSubSystem> SysSubSystems { get; set; }
        public virtual DbSet<SysUserCridential> SysUserCridentials { get; set; }
        public virtual DbSet<SysUserInfo> SysUserInfos { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning Please Set User Id and Password
                optionsBuilder.UseSqlServer("Server=tcp:196.189.91.173,1433;initial catalog=AradashiManager;user id=**;password=**;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModificationType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modificationType");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedOn");

                entity.Property(e => e.ModifiedSystem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("modifiedSystem");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SysLogs__userId__412EB0B6");
            });

            modelBuilder.Entity<SysSubSystem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SybSystem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sybSystem");
            });

            modelBuilder.Entity<SysUserCridential>(entity =>
            {
                entity.ToTable("SysUser_cridentials");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<SysUserInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SysUser_info");

                entity.Property(e => e.AccCreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("accCreatedOn");

                entity.Property(e => e.AccCreator).HasColumnName("accCreator");

                entity.Property(e => e.AccStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("accStatus");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");

                entity.Property(e => e.SubSys1Per).HasColumnName("subSys1_per");

                entity.Property(e => e.SubSys2Per).HasColumnName("subSys2_per");

                entity.Property(e => e.SubSys3Per).HasColumnName("subSys3_per");

                entity.Property(e => e.SubSys4Per).HasColumnName("subSys4_per");

                entity.Property(e => e.SubSys5Per).HasColumnName("subSys5_per");

                entity.Property(e => e.SubSys6Per).HasColumnName("subSys6_per");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.HasOne(d => d.AccCreatorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AccCreator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SysUser_i__accCr__3C69FB99");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SysUser_info__id__3A81B327");

                entity.HasOne(d => d.TitleNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Title)
                    .HasConstraintName("FK__SysUser_i__title__3B75D760");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.ToTable("Title");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
