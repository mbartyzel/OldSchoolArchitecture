using System;
namespace BusinessLogic.BnsIT.Library
{
    public class Reader
    {
        public String CardId { get; private set; }

        public Reader(String cardId)
        {
            this.CardId = cardId;
        }
    }
}
