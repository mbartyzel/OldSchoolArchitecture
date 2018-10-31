using System;
using Services.BnsIT.Library;
using BusinessLogic.BnsIT.Library;

namespace DataAccessLayer.BnsIT.Library
{
    public class DataAccessObject : IDataAccessObject
    {
		public void SaveBorrowing(Borrowing borrowing)
        {
            //save
        }

		public Book FindBook(String isbn)
        {
            return new Book("isbn-123");
        }

		public Reader FindReader(String cardId)
        {
            return new Reader("cardId-123");
        }
    }
}
