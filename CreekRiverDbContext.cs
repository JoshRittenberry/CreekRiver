using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }
    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>().HasData(new Reservation[]
        {
        new Reservation {Id = 1, CampsiteId = 3, UserProfileId = 5, CheckinDate = new DateTime(2023, 5, 12), CheckoutDate = new DateTime(2023, 5, 15)},
        new Reservation {Id = 2, CampsiteId = 1, UserProfileId = 2, CheckinDate = new DateTime(2023, 6, 20), CheckoutDate = new DateTime(2023, 6, 25)},
        new Reservation {Id = 3, CampsiteId = 4, UserProfileId = 7, CheckinDate = new DateTime(2023, 7, 8), CheckoutDate = new DateTime(2023, 7, 13)},
        new Reservation {Id = 4, CampsiteId = 2, UserProfileId = 1, CheckinDate = new DateTime(2023, 8, 15), CheckoutDate = new DateTime(2023, 8, 20)},
        new Reservation {Id = 5, CampsiteId = 5, UserProfileId = 4, CheckinDate = new DateTime(2023, 9, 3), CheckoutDate = new DateTime(2023, 9, 10)}
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
        new UserProfile {Id= 1, FirstName = "John", LastName = "Doe", Email = "john.doe@email.com"},
        new UserProfile {Id= 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@email.com"},
        new UserProfile {Id= 3, FirstName = "Emily", LastName = "Johnson", Email = "emily.johnson@email.com"},
        new UserProfile {Id= 4, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@email.com"},
        new UserProfile {Id= 5, FirstName = "David", LastName = "Wilson", Email = "david.wilson@email.com"},
        new UserProfile {Id= 6, FirstName = "Sarah", LastName = "Miller", Email = "sarah.miller@email.com"},
        new UserProfile {Id= 7, FirstName = "Alice", LastName = "Davis", Email = "alice.davis@email.com"}
        });

        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
        new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://i.ibb.co/QCbBL1G/Barred-Owl.webp"},
        new Campsite {Id = 2, CampsiteTypeId = 1, Nickname = "Whispering Pines Haven", ImageUrl="https://i.ibb.co/wCjRnCj/Whispering-Pines-Haven.webp"},
        new Campsite {Id = 3, CampsiteTypeId = 1, Nickname = "Blue Heron Retreat", ImageUrl="https://i.ibb.co/LtcrVbH/Blue-Heron-Retreat.webp"},
        new Campsite {Id = 4, CampsiteTypeId = 1, Nickname = "Rippling Brook Lodge", ImageUrl="https://i.ibb.co/dDgf1g6/Rippling-Brook-Lodge.webp"},
        new Campsite {Id = 5, CampsiteTypeId = 1, Nickname = "Twilight Meadows Camp", ImageUrl="https://i.ibb.co/ZJ9RCbj/Twilight-Meadows-Camp.webp"},
        new Campsite {Id = 6, CampsiteTypeId = 1, Nickname = "Boulder's Edge Bivouac", ImageUrl="https://i.ibb.co/2skbJF4/Boulder-Edge-Bivouac.webp"}
        });

        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
        new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
        new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
        new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
        new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
        });
    }
}