using Davantes_SODV1255_LMS_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Davantes_SODV1255_LMS_Assignment1.Controllers {

    [ApiController]
    [Route("/books")]
    public class BookController : Controller {

        //GET /books
        [HttpGet]
        public IActionResult GetAllBooks() {

            List<Book> books = new List<Book>(){
                new Book(1, "The Silent Code", "Alex Harper", "Blue Oak Press", "2018", true),
                new Book(2, "Shadows of Tomorrow", "Lena Brooks", "Northwind Publishing", "2020", true),
                new Book(3, "Echoes in the Grid", "Marcus Lee", "Ironleaf Books", "2019", true),
            };
            return Json(books);
        }

        //GET /books/1
        [HttpGet("{id}")]
        public IActionResult GetBook(int id) {
            Book book = new Book(id, "The Silent Code", "Alex Harper", "Blue Oak Press", "2018", true);
            return Json(book);
        }

        //POST /books
        [HttpPost]
        public IActionResult CreateBook() {
            Book newBook = new Book(1, "The Silent Code", "Alex Harper", "Blue Oak Press", "2018", true);
            return Json(new { message = "New book created", book = newBook });
        }


        //PUT /books/1
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id) {
            Book editBook = new Book(id, "The Silent Code", "Alex Harper", "Blue Oak Press", "2018", true);
            return Json(new { message = $"Book with ID of {editBook.ID} is updated", book = editBook });
        }

        //DELETE /books/1
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id) {
            return Json(new { message = $"Book with ID of {id} is deleted"});
        }
    }
}
