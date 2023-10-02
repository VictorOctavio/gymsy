using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gymsy.App.Models;

public partial class GymsyDbContext : DbContext
{
    public GymsyDbContext()
    {
    }

    public GymsyDbContext(DbContextOptions<GymsyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DataFisic> DataFisics { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Pay> Pays { get; set; }

    public virtual DbSet<PayType> PayTypes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<TrainingPlan> TrainingPlans { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK_Admin_id_admin");

            entity.ToTable("Admin");

            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.Recaudacion).HasColumnName("recaudacion");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Admins)
                .HasForeignKey(d => d.IdPerson)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admin_id_person");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PK_Client_id_client");

            entity.ToTable("Client");

            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.IdTrainingPlan).HasColumnName("id_trainingPlan");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.LastExpiration)
                .HasColumnType("date")
                .HasColumnName("lastExpiration");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdPerson)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_id_person");

            entity.HasOne(d => d.IdTrainingPlanNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdTrainingPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_id_triningPlan");
        });

        modelBuilder.Entity<DataFisic>(entity =>
        {
            entity.HasKey(e => e.IdDataFisic).HasName("PK_DataFisic_id_dataFisic");

            entity.ToTable("DataFisic");

            entity.Property(e => e.IdDataFisic).HasColumnName("id_dataFisic");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.DataFisics)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataFisic_id_client");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.IdImage).HasName("PK_Image_id_image");

            entity.ToTable("Image");

            entity.Property(e => e.IdImage).HasColumnName("id_image");
            entity.Property(e => e.IdDataFisic).HasColumnName("id_dataFisic");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imageURL");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");

            entity.HasOne(d => d.IdDataFisicNavigation).WithMany(p => p.Images)
                .HasForeignKey(d => d.IdDataFisic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Image_id_dataFisic");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.IdInstructor).HasName("PK_Instructor_id_instructor");

            entity.ToTable("Instructor");

            entity.Property(e => e.IdInstructor).HasColumnName("id_instructor");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.IdPerson)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructor_id_person");
        });

        modelBuilder.Entity<Pay>(entity =>
        {
            entity.HasKey(e => e.IdPay).HasName("PK_Pay_id_pay");

            entity.ToTable("Pay");

            entity.Property(e => e.IdPay).HasColumnName("id_pay");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.DestinatarioId).HasColumnName("destinatario_id");
            entity.Property(e => e.IdPayType).HasColumnName("id_payType");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.RemitenteId).HasColumnName("remitente_id");

            entity.HasOne(d => d.Destinatario).WithMany(p => p.PayDestinatarios)
                .HasForeignKey(d => d.DestinatarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pay_id_personDes");

            entity.HasOne(d => d.IdPayTypeNavigation).WithMany(p => p.Pays)
                .HasForeignKey(d => d.IdPayType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pay_id_payType");

            entity.HasOne(d => d.Remitente).WithMany(p => p.PayRemitentes)
                .HasForeignKey(d => d.RemitenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pay_id_personRem");
        });

        modelBuilder.Entity<PayType>(entity =>
        {
            entity.HasKey(e => e.IdPayType).HasName("PK_PayType_id_payType");

            entity.ToTable("PayType");

            entity.Property(e => e.IdPayType).HasColumnName("id_payType");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.IdPerson).HasName("PK_Person_id_person");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Nickname, "Q_Person_nickname").IsUnique();

            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.Avatar)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday)
                .HasColumnType("date")
                .HasColumnName("birthday");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nickname)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("nickname");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.People)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Person_id_person");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK_Rol_idRol");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TrainingPlan>(entity =>
        {
            entity.HasKey(e => e.IdTrainingPlan).HasName("PK_TrainingPlan_id_trainingPlan");

            entity.ToTable("TrainingPlan");

            entity.Property(e => e.IdTrainingPlan).HasColumnName("id_trainingPlan");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IdInstructor).HasColumnName("id_instructor");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.IdInstructorNavigation).WithMany(p => p.TrainingPlans)
                .HasForeignKey(d => d.IdInstructor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingPlan_id_instructor");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.IdWallet).HasName("PK_Wallet_id_wallet");

            entity.ToTable("Wallet");

            entity.Property(e => e.IdWallet).HasColumnName("id_wallet");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.Retirable).HasColumnName("retirable");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.IdPerson)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Wallet_id_person");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
