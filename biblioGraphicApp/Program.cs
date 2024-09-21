using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource resource1 = new Resource("The Mythical Man-month", "Non-fiction");
            resource1.GetInfo();
            resource1.UpdateStatus();

            Console.WriteLine();

            Book book1 = new Book(
                "Code: The Hidden Language of Computer Hardware and Software",
                "Non-Fiction",
                "Charles Petzold",
                396
            );
            book1.GetInfo();

            Console.WriteLine();

            Periodical periodical = new Periodical("AI ERA", "Technology", "Monthly");
            periodical.GetInfo();
            periodical.UpdateStatus();
            resource1.GetInfo();

            Console.WriteLine();

            Video video = new Video(
                "Ex Machina",
                "Sci-Fi",
                "Alex Garland",
                108,
                "On-Demand"
            );
            video.GetInfo();


        }
    }
}