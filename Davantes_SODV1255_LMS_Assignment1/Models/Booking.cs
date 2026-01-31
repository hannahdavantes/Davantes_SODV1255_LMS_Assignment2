using System.ComponentModel.DataAnnotations;

namespace Davantes_SODV1255_LMS_Assignment1.Models {
    public class Booking {
        public int ID { get; set; }

        [Required(ErrorMessage = "BookID is required")]
        public int BookID { get; set; }

        [Required(ErrorMessage = "ReaderID is required")]
        public int ReaderID { get; set; }

        [Required(ErrorMessage = "Booking date is required")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(20, ErrorMessage = "Status cannot exceed 20 characters")]
        public string Status { get; set; }

        public Booking() {
        }

        public Booking(int id, int bookID, int readerID) {
            ID = id;
            BookID = bookID;
            ReaderID = readerID;
            BookingDate = DateTime.Now;
            DueDate = BookingDate.AddDays(14);
            ReturnDate = null;
            Status = "Borrowed"; //Returned, Overdue
        }
    }
}
