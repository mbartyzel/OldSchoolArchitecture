using System;
using BusinessLogic.BnsIT.Library;
namespace Services.BnsIT.Library
{
    public class BorrowBookService
    {
        public IDataAccessObject dao;

        public void BorrowBook(String isbn, String cardId) 
        {
            Reader reader = dao.FindReader(cardId);
            Book book = dao.FindBook(isbn);

            Borrowing borrowing = new Borrowing(book, reader);

            dao.SaveBorrowing(borrowing);
        }
    }
}
