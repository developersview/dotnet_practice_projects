using System;

namespace BiblioInheritance
{
    class Book : Resource
    {
        public string Author { get; set; }
        public int Pagecount { get; set; }

        public Book(string title, string category, string author, int pagecount) : base(title, category)
        {
            this.Author = author;
            this.Pagecount = pagecount;
        }

    }
}