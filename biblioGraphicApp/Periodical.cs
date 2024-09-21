using System;

namespace BiblioInheritance
{
    class Periodical : Resource
    {
        public string Period { get; set; }

        public Periodical(string title, string category, string period) : base(title, category)
        {
            this.Period = period;
        }

        public override void UpdateStatus()
        {
            Status = (Status == "out") ? "In-Use" : "Available";
        }

    }
}