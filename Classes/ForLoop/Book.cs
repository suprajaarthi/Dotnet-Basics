using System;

namespace ForLoop
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
    }
}

//other way 

using System;

namespace ForLoop
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
    
        public Book(string atitle,string aauthor,string apages)
        {
            title=atitle;
            author=aauthor;
            pages=apages;
        }
    }
}
