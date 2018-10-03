using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreMVC.Models.DB
{
    public partial class AuthenticationContext : DbContext
    {
        public AuthenticationContext()
        {
        }

        public AuthenticationContext(DbContextOptions<AuthenticationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContractingEntities> ContractingEntities { get; set; }
        public virtual DbSet<ContractingEntitiesPermission> ContractingEntitiesPermission { get; set; }
        public virtual DbSet<ContractingEntitiesRoles> ContractingEntitiesRoles { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentPermission> DepartmentPermission { get; set; }
        public virtual DbSet<DepartmentRoles> DepartmentRoles { get; set; }
        public virtual DbSet<Facilities> Facilities { get; set; }
        public virtual DbSet<FacilityPermission> FacilityPermission { get; set; }
        public virtual DbSet<FacilityRoles> FacilityRoles { get; set; }
        public virtual DbSet<HospitalPermission> HospitalPermission { get; set; }
        public virtual DbSet<HospitalRoles> HospitalRoles { get; set; }
        public virtual DbSet<Hospitals> Hospitals { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHISHIRP-MSD;Database=Authentication;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractingEntities>(entity =>
            {
                entity.HasKey(e => e.CeId)
                    .HasName("PK__Contract__51ACCFA45DB06B1E");

                entity.Property(e => e.CeId).HasColumnName("CE_Id");

                entity.Property(e => e.CeName)
                    .HasColumnName("CE_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyId).HasColumnName("Policy_Id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.ContractingEntities)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contracti__Polic__3E52440B");
            });

            modelBuilder.Entity<ContractingEntitiesPermission>(entity =>
            {
                entity.HasKey(e => e.CePermissionId)
                    .HasName("PK__Contract__4F5CF11FC4DAA58A");

                entity.ToTable("ContractingEntities_Permission");

                entity.HasIndex(e => e.PermissionName)
                    .HasName("UQ__Contract__B9881F058B62F17D")
                    .IsUnique();

                entity.Property(e => e.CePermissionId).HasColumnName("CE_Permission_Id");

                entity.Property(e => e.CeId).HasColumnName("CE_Id");

                entity.Property(e => e.PermissionName)
                    .HasColumnName("Permission_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ce)
                    .WithMany(p => p.ContractingEntitiesPermission)
                    .HasForeignKey(d => d.CeId)
                    .HasConstraintName("FK__Contracti__CE_Id__45F365D3");
            });

            modelBuilder.Entity<ContractingEntitiesRoles>(entity =>
            {
                entity.HasKey(e => e.CeRoleId)
                    .HasName("PK__Contract__D095A9DEEA76C7BF");

                entity.ToTable("ContractingEntities_Roles");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Contract__2BC63C0B87BC9FAB")
                    .IsUnique();

                entity.Property(e => e.CeRoleId).HasColumnName("CE_Role_Id");

                entity.Property(e => e.CeId).HasColumnName("CE_Id");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ce)
                    .WithMany(p => p.ContractingEntitiesRoles)
                    .HasForeignKey(d => d.CeId)
                    .HasConstraintName("FK__Contracti__CE_Id__4222D4EF");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("Department_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityId).HasColumnName("Facility_Id");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK__Departmen__Facil__5DCAEF64");
            });

            modelBuilder.Entity<DepartmentPermission>(entity =>
            {
                entity.ToTable("Department_Permission");

                entity.HasIndex(e => e.PermissionName)
                    .HasName("UQ__Departme__B9881F051521C36F")
                    .IsUnique();

                entity.Property(e => e.DepartmentPermissionId).HasColumnName("Department_Permission_Id");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.PermissionName)
                    .HasColumnName("Permission_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentPermission)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Departmen__Depar__656C112C");
            });

            modelBuilder.Entity<DepartmentRoles>(entity =>
            {
                entity.HasKey(e => e.DepartmentRoleId)
                    .HasName("PK__Departme__9CBE86657840A9D3");

                entity.ToTable("Department_Roles");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Departme__2BC63C0B913A33A1")
                    .IsUnique();

                entity.Property(e => e.DepartmentRoleId).HasColumnName("Department_Role_Id");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentRoles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Departmen__Depar__619B8048");
            });

            modelBuilder.Entity<Facilities>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("PK__Faciliti__CEAA2C254FB7C89F");

                entity.Property(e => e.FacilityId).HasColumnName("Facility_Id");

                entity.Property(e => e.FacilityName)
                    .HasColumnName("Facility_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Facilities)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK__Facilitie__Hospi__534D60F1");
            });

            modelBuilder.Entity<FacilityPermission>(entity =>
            {
                entity.ToTable("Facility_Permission");

                entity.HasIndex(e => e.PermissionName)
                    .HasName("UQ__Facility__B9881F055085FA6F")
                    .IsUnique();

                entity.Property(e => e.FacilityPermissionId).HasColumnName("Facility_Permission_Id");

                entity.Property(e => e.FacilityId).HasColumnName("Facility_Id");

                entity.Property(e => e.PermissionName)
                    .HasColumnName("Permission_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityPermission)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK__Facility___Facil__5AEE82B9");
            });

            modelBuilder.Entity<FacilityRoles>(entity =>
            {
                entity.HasKey(e => e.FacilityRoleId)
                    .HasName("PK__Facility__97EC4EF63730F5D7");

                entity.ToTable("Facility_Roles");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Facility__2BC63C0B5025FD86")
                    .IsUnique();

                entity.Property(e => e.FacilityRoleId).HasColumnName("Facility_Role_Id");

                entity.Property(e => e.FacilityId).HasColumnName("Facility_Id");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityRoles)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK__Facility___Facil__571DF1D5");
            });

            modelBuilder.Entity<HospitalPermission>(entity =>
            {
                entity.ToTable("Hospital_Permission");

                entity.HasIndex(e => e.PermissionName)
                    .HasName("UQ__Hospital__B9881F054D112646")
                    .IsUnique();

                entity.Property(e => e.HospitalPermissionId).HasColumnName("Hospital_Permission_Id");

                entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");

                entity.Property(e => e.PermissionName)
                    .HasColumnName("Permission_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalPermission)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK__Hospital___Hospi__5070F446");
            });

            modelBuilder.Entity<HospitalRoles>(entity =>
            {
                entity.HasKey(e => e.HospitalRoleId)
                    .HasName("PK__Hospital__884CEFEB0263BA7B");

                entity.ToTable("Hospital_Roles");

                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Hospital__2BC63C0BD60AD921")
                    .IsUnique();

                entity.Property(e => e.HospitalRoleId).HasColumnName("Hospital_Role_Id");

                entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalRoles)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK__Hospital___Hospi__4CA06362");
            });

            modelBuilder.Entity<Hospitals>(entity =>
            {
                entity.HasKey(e => e.HospitalId)
                    .HasName("PK__Hospital__09C0BDA533CBE061");

                entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");

                entity.Property(e => e.CeId).HasColumnName("CE_Id");

                entity.Property(e => e.HospitalName)
                    .HasColumnName("Hospital_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ce)
                    .WithMany(p => p.Hospitals)
                    .HasForeignKey(d => d.CeId)
                    .HasConstraintName("FK__Hospitals__CE_Id__48CFD27E");
            });

            modelBuilder.Entity<Policies>(entity =>
            {
                entity.HasKey(e => e.PolicyId)
                    .HasName("PK__Policies__47DB3B3B13ED7F6D");

                entity.Property(e => e.PolicyId).HasColumnName("policy_ID");

                entity.Property(e => e.PolicyName)
                    .HasColumnName("policy_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("Reg_Id");

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Policies__Reg_Id__3B75D760");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__Registra__38E98FCF356E3588");

                entity.HasIndex(e => e.Password)
                    .HasName("UQ__Registra__6E2DBEDED1224E1A")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__Registra__F3DBC5725C4BB03B")
                    .IsUnique();

                entity.Property(e => e.RegId).HasColumnName("Reg_ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
