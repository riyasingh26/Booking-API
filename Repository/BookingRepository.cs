using BookingAPI.DataAccessLayer;
using BookingAPI.Models;

namespace BookingAPI.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDAL _myDAL;

        public BookingRepository(BookingDAL bookingContext)
        {
            _myDAL = bookingContext;
        }

        public Booking AddBooking(Booking booking)
        {
            _myDAL.Bookings.Add(booking);
            _myDAL.SaveChanges();
            return booking;
        }

        public bool DeleteBooking(int id)
        {
            Booking booking = _myDAL.Bookings.Find(id);
            _myDAL.Bookings.Remove(booking);
            _myDAL.SaveChanges();
            return true;
        }

        public List<Booking> GetAllBookings()
        {
            List<Booking> allBookings = _myDAL.Bookings.ToList();
            return allBookings;
        }

        public Booking GetOneBooking(int id)
        {
            Booking booking = _myDAL.Bookings.Find(id);
            return booking;
        }

        public Booking UpdateBooking(int id, Booking bookingReceived)
        {
            Booking bookingFound = _myDAL.Bookings.Find(id);
            bookingFound.FirstName = bookingReceived.FirstName;
            bookingFound.LastName = bookingReceived.LastName;
            bookingFound.UserID = bookingReceived.UserID;
            _myDAL.SaveChanges();

            return bookingFound;
        }
    }
}
