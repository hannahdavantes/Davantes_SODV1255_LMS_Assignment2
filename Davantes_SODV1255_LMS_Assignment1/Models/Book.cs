namespace Davantes_SODV1255_LMS_Assignment1.Models {
    public class Book {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string YearPublished { get; set; }
        public bool IsAvailable { get; set; }

        public Book() { }

        public Book(int iD, string title, string author, string publisher, string yearPublished, bool isAvailable) {
            ID = iD;
            Title = title;
            Author = author;
            Publisher = publisher;
            YearPublished = yearPublished;
            IsAvailable = isAvailable;
        }
    }
}
