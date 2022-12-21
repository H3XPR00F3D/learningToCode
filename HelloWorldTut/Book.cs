using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTut {
    internal class Book {
        //Class Attributes.
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)//Constructor. Special method inside of classe when object from class is called.
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public Book()
        {

        }
    }

}

