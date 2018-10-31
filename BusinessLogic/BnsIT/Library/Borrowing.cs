using System;
namespace BusinessLogic.BnsIT.Library
{
    public class Borrowing
    {
        private Book book;

        private Reader reader;

        public String BookIsbn { get { return book.Isbn; } }

        public String ReaderCardId { get { return reader.CardId; } }

        public Borrowing(Book book, Reader reader)
        {
            this.book = book;
            this.reader = reader;
        }
    }
}
