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

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DataFisic> DataFisics { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Pay> Pays { get; set; }

    public virtual DbSet<PayType> PayTypes { get; set; }

    public virtual DbSet<Person> Peoples { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<TrainingPlan> TrainingPlans { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Administ__3213E83F09382EED");

            entity.ToTable("Administrator");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Administrators)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administr__perso__628FA481");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3213E83FFEC7EEB2");

            entity.ToTable("Client");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.LastExpiration)
                .HasColumnType("date")
                .HasColumnName("last_expiration");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.PlanId).HasColumnName("plan_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Clients)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Client__person_i__6FE99F9F");

            entity.HasOne(d => d.Plan).WithMany(p => p.Clients)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Client__plan_id__70DDC3D8");
        });

        modelBuilder.Entity<DataFisic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DataFisi__3213E83FA5F7F1F8");

            entity.ToTable("DataFisic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Client).WithMany(p => p.DataFisics)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DataFisic__clien__73BA3083");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Image__3213E83FD96ADE33");

            entity.ToTable("Image");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DatafisicId).HasColumnName("datafisic_id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imageURL");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");

            entity.HasOne(d => d.Datafisic).WithMany(p => p.Images)
                .HasForeignKey(d => d.DatafisicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Image__datafisic__76969D2E");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Instruct__3213E83FB5F3C23A");

            entity.ToTable("Instructor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Instructo__perso__656C112C");
        });

        modelBuilder.Entity<Pay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pay__3213E83FA8E7D6C4");

            entity.ToTable("pay");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.DestinatarioId).HasColumnName("destinatario_id");
            entity.Property(e => e.Expiration)
                .HasColumnType("date")
                .HasColumnName("expiration");
            entity.Property(e => e.PaytypeId).HasColumnName("paytype_id");
            entity.Property(e => e.RemitenteId).HasColumnName("remitente_id");

            entity.HasOne(d => d.Destinatario).WithMany(p => p.PayDestinatarios)
                .HasForeignKey(d => d.DestinatarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay__destinatari__797309D9");

            entity.HasOne(d => d.Paytype).WithMany(p => p.Pays)
                .HasForeignKey(d => d.PaytypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay__paytype_id__7B5B524B");

            entity.HasOne(d => d.Remitente).WithMany(p => p.PayRemitentes)
                .HasForeignKey(d => d.RemitenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay__remitente_i__7A672E12");
        });

        modelBuilder.Entity<PayType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayType__3213E83F45680586");

            entity.ToTable("PayType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3213E83F06DD75FB");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Nickname, "UQ__Person__5CF1C59B3D3E79B3").IsUnique();

            entity.Property(e => e.Id)   
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Avatar)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.Cbu).HasColumnName("CBU");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("nickname");
            entity.Property(e => e.Password)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.People)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person__rol_id__5FB337D6");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3213E83F15A3F7ED");

            entity.ToTable("Rol");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TrainingPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Training__3213E83FAE32DC38");

            entity.ToTable("TrainingPlan");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Instructor).WithMany(p => p.TrainingPlans)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainingP__instr__6B24EA82");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wallet__3213E83FCBCD08C3");

            entity.ToTable("Wallet");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wallet__person_i__68487DD7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
