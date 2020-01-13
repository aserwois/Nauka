using System;

namespace clasobje
{
    class book
    {
        public string title;
        public string author;
        public int pages;

        public book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public bool isBookBig()
        {
            if(pages > 300) 
            {
                return true;
            }

            return false;
        }
    }
}