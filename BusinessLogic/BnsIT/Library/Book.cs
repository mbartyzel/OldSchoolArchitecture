using System;
namespace BusinessLogic.BnsIT.Library
{
    public class Book
    {
        public String Isbn { get; private set; }   

        public Book(String isbn)
        {
            this.Isbn = isbn;
        }
    }
}
