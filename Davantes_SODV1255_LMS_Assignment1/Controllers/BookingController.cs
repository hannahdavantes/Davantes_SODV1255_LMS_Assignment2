using Davantes_SODV1255_LMS_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davantes_SODV1255_LMS_Assignment1.Controllers {
    [ApiController]
    [Route("/bookings")]
    public class BookingController : Controller {

        //GET /bookings
        [HttpGet]
        public IActionResult GetAllBookings() {
            List<Booking> bookings = new List<Booking>() {
                new Booking(1, 1, 1),
                new Booking(2, 2, 3),
                new Booking(3, 3, 2)
            };
            return Json(bookings);
        }

        //GET /bookings/1
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id) {
            Booking booking = new Booking(id, 1, 1);
            return Json(booking);
        }

        //POST /bookings
        [HttpPost]
        public IActionResult CreateBooking() {
            Booking newBooking = new Booking(4, 2, 3);
            return Json(new { message = "New booking created", booking = newBooking });
        }

        //PUT /bookings/1
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id) {
            Booking editBooking = new Booking(id, 2, 3);
            return Json(new { message = $"Booking with ID of {editBooking.ID} is updated", booking = editBooking });
        }

        //DELETE /bookings/1
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id) {
            return Json(new { message = $"Booking with ID of {id} is deleted" });
        }
    }
}
