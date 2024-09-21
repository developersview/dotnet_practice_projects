using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        string Director { get; set; }
        int Runtime { get; set; }
        string Mediatype { get; set; }

        public Video(string title, string category, string director, int runtime, string mediatype) : base(title, category)
        {
            this.Director = director;
            this.Runtime = runtime;
            this.Mediatype = mediatype;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"RunTime: {Runtime}");
            Console.WriteLine($"MediaType: {Mediatype}");

        }


    }

}
