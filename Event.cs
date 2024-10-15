using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMSA
{
    // Custom event class
    public class EventOrAnnouncement
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; } // Added property for image path

        public EventOrAnnouncement(string name, string category, DateTime date, string type, string imagePath)
        {
            Name = name;
            Category = category;
            Date = date;
            Type = type;
            ImagePath = imagePath; // Initialize image path
        }
    }
}


