using System;

namespace Library
{
    [Serializable]
    class BooksClass
    {
        public string caption, author, isbn, bbk, pblshngCompn, pblshYear, pages, giveDate, returnDate, whoTook;

        public BooksClass(string caption, string author, string isbn, string bbk, string pblshngCompn, string pblshYear, string pages, string giveDate, string returnDate, string whoTook)
        {
            this.caption = caption;
            this.author = author;
            this.isbn = isbn;
            this.bbk = bbk;
            this.pblshngCompn = pblshngCompn;
            this.pblshYear = pblshYear;
            this.pages = pages;
            this.giveDate = giveDate;
            this.returnDate = returnDate;
            this.whoTook = whoTook;
        }
        public BooksClass() : this("-", "-", "-", "-", "-", "-", "-", "-", "-", "-") { }
    }
}
