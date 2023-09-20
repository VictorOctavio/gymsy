using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gymsy.Models;

public partial class GymsyContext : DbContext
{
    public GymsyContext()
    {
    }

    public GymsyContext(DbContextOptions<GymsyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DataFisic> DataFisics { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Pay> Pays { get; set; }

    public virtual DbSet<PayPlan> PayPlans { get; set; }

    public virtual DbSet<PayType> PayTypes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
       

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin__3213E83F760FEB97");

            entity.ToTable("Admin");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.Recaudacion).HasColumnName("recaudacion");

            entity.HasOne(d => d.Person).WithMany(p => p.Admins)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin__person_id__3D5E1FD2");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3213E83F5B0148EB");

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
                .HasConstraintName("FK__Client__person_i__4AB81AF0");

            entity.HasOne(d => d.Plan).WithMany(p => p.Clients)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Client__plan_id__4BAC3F29");
        });

        modelBuilder.Entity<DataFisic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DataFisi__3213E83F0E695388");

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
                .HasConstraintName("FK__DataFisic__clien__4E88ABD4");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Image__3213E83FD08DA662");

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
                .HasConstraintName("FK__Image__datafisic__5165187F");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Instruct__3213E83F9CC76ECE");

            entity.ToTable("Instructor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Instructo__perso__403A8C7D");
        });

        modelBuilder.Entity<Pay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pay__3213E83F6B2BEA9E");

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
                .HasConstraintName("FK__pay__destinatari__5441852A");

            entity.HasOne(d => d.Paytype).WithMany(p => p.Pays)
                .HasForeignKey(d => d.PaytypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay__paytype_id__5629CD9C");

            entity.HasOne(d => d.Remitente).WithMany(p => p.PayRemitentes)
                .HasForeignKey(d => d.RemitenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay__remitente_i__5535A963");
        });

        modelBuilder.Entity<PayPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pay_plan__3213E83F667E7159");

            entity.ToTable("pay_plan");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Instructor).WithMany(p => p.PayPlans)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pay_plan__instru__45F365D3");
        });

        modelBuilder.Entity<PayType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayType__3213E83FD5D3203D");

            entity.ToTable("PayType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3213E83FC27679BE");

            entity.ToTable("Person");

            entity.HasIndex(e => e.Nickname, "UQ__Person__5CF1C59B470E6893").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Avatar)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("date")
                .HasColumnName("createdAt");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasMaxLength(6)
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
                .HasConstraintName("FK__Person__rol_id__3A81B327");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3213E83F4A6188BB");

            entity.ToTable("Rol");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wallet__3213E83F667E15FC");

            entity.ToTable("Wallet");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.Retirable).HasColumnName("retirable");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.Person).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wallet__person_i__4316F928");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
