﻿using System;
using Services.BnsIT.Library;
namespace UI.BnsIT.Library
{
    public class BorrowBookController
    {

        public String Isbn { get; set; }

        public String CardId { get; set; }

        public BorrowBookService service;

        public void Execute() 
        {
            service.BorrowBook(Isbn,CardId);
        }

    }
}
