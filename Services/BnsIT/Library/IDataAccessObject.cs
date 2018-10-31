﻿using System;
using BusinessLogic.BnsIT.Library;

namespace Services.BnsIT.Library
{
    public interface IDataAccessObject
    {
        void SaveBorrowing(Borrowing borrowing);

        Book FindBook(String isbn);

        Reader FindReader(String cardId);
    }
}
