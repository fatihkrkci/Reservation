using Microsoft.EntityFrameworkCore;
using Reservation.Hotels.Entities;

namespace Reservation.Hotels.Context
{
    public class HotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;initial catalog=HotelReservationDb;User=sa;Password=123456aA*;trust server certificate=true");
        }

        public DbSet<HotelInfo> HotelInfos { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
