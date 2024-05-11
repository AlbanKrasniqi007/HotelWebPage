using Hotel_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Web_App.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
