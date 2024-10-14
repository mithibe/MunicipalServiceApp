using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMSA
{
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        public Event(string name, string category, DateTime date)
        {
            Name = name;
            Category = category;
            Date = date;
        }
    }
}
