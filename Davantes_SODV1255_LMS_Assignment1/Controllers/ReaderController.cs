using Davantes_SODV1255_LMS_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davantes_SODV1255_LMS_Assignment1.Controllers {
    [ApiController]
    [Route("/readers")]
    public class ReaderController : Controller {
        //GET /readers
        [HttpGet]
        public IActionResult GetAllReaders() {
            List<Reader> readers = new List<Reader>() {
                new Reader(1, "John", "Doe", "john.doe@email.com", "1234567890"),
                new Reader(2, "Jane", "Smith", "jane.smith@email.com", "0987654321"),
                new Reader(3, "Mike", "Brown", "mike.brown@email.com", "5556667777")
            };
            return Json(readers);
        }
        //GET /readers/1
        [HttpGet("{id}")]
        public IActionResult GetReader(int id) {
            Reader reader = new Reader(id, "John", "Doe", "john.doe@email.com", "1234567890");
            return Json(reader);
        }
        //POST /readers
        [HttpPost]
        public IActionResult CreateReader() {
            Reader newReader = new Reader(4, "Anna", "White", "anna.white@email.com", "1112223333");
            return Json(new { message = "New reader created", reader = newReader });
        }
        //PUT /readers/1
        [HttpPut("{id}")]
        public IActionResult UpdateReader(int id) {
            Reader editReader = new Reader(id, "John", "Doe", "john.updated@email.com", "9998887777");
            return Json(new { message = $"Reader with ID of {editReader.ID} is updated", reader = editReader });
        }
        //DELETE /readers/1
        [HttpDelete("{id}")]
        public IActionResult DeleteReader(int id) {
            return Json(new { message = $"Reader with ID of {id} is deleted" });
        }
    }
}
