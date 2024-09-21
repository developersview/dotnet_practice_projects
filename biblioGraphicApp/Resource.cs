using System;

namespace BiblioInheritance
{
    public class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; protected set; }

        public Resource(string title, string category)
        {
            this.Title = title;
            this.Category = category;
            this.Status = "Available";
        }

        public virtual void UpdateStatus()
        {
            Status = (Status == "Out") ? "Available" : "Out";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
