using System;
using UI.BnsIT.Library;
        
namespace UI.BnsIT
{
    class MainView
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Book borrowing");

            Console.Write("Type ISBN: ");
            String isbn = Console.ReadLine();

            Console.Write("Type reader's library card id: ");
            String cardId = Console.ReadLine();

            BorrowBookController controller = new BorrowBookController();
            controller.CardId = cardId;
            controller.Isbn = isbn;

            controller.Execute();
        }
    }
}
