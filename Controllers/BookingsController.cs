using BookingAPI.DataAccessLayer;
using BookingAPI.Models;
using BookingAPI.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private static IBookingRepository _repository;

        public BookingsController(BookingDAL myDAL)
        {
            _repository = new BookingRepository(myDAL);
        }

        // GET: api/<BookingsController>
        [HttpGet]
        public List<Booking> Get()
        {
            return _repository.GetAllBookings();
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
        public Booking Get(int id)
        {
            return _repository.GetOneBooking(id);
        }

        // POST api/<BookingsController>
        [HttpPost]
        public Booking Post([FromBody] Booking booking)
        {
            return _repository.AddBooking(booking);
        }

        // PUT api/<BookingsController>/5
        [HttpPut("{id}")]
        public Booking Put(int id, [FromBody] Booking booking)
        {
            return _repository.UpdateBooking(id, booking);
        }

        // DELETE api/<BookingsController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _repository.DeleteBooking(id);
        }
    }
}
