using BookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.DataAccessLayer
{
    public class BookingDAL : DbContext
    {
        public BookingDAL(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
    }
}
