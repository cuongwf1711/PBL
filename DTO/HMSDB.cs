using PBL.Migrations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PBL.DTO
{
    public class HMSDB : DbContext
    {
        public HMSDB() : base("name=HMSDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HMSDB, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<HMSDB>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Map(m =>
                    {
                        m.MapInheritedProperties();
                        m.ToTable("Accounts");
                    })
                .HasKey(k => k.PersonId);
            modelBuilder.Entity<Customer>()
                .Map(m =>
                    {
                        m.MapInheritedProperties();
                        m.ToTable("Customers");
                    })
                .HasKey(k => k.PersonId);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Payment>()
                .HasMany<Reservation>(r => r.Reservations)
                .WithRequired(p => p.Payment)
                .HasForeignKey<int>(fk => fk.PaymentId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Payment>()
                .HasMany<Addition>(a => a.Additions)
                .WithRequired(p => p.Payment)
                .HasForeignKey<int>(fk => fk.PaymentId)
                .WillCascadeOnDelete();
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<TypeRoom> TypeRooms { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Addition> Additions { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Late> Lates { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}