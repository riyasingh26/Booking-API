using BookingAPI.Models;

namespace BookingAPI.Repository
{
    public interface IBookingRepository
    {
        List<Booking> GetAllBookings();
        Booking GetOneBooking(int id);
        Booking AddBooking(Booking booking);
        Booking UpdateBooking(int id, Booking booking);
        Boolean DeleteBooking(int id);
    }
}
