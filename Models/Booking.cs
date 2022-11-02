using System.ComponentModel.DataAnnotations;

namespace BookingAPI.Models
{
    public class Booking
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int BookingID { get; set; }
        public int UserID { get; set; }
    }
}
