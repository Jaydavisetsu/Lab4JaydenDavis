using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_API_Jayden
{
    public class ZeldaData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleasedDate { get; set; }



        public ZeldaData(string name, string description, string developer, string publisher, DateTime releasedDate)
        {
            this.Name = name;
            this.Description = description;
            this.Developer = developer;
            this.Publisher = publisher;
            this.ReleasedDate = releasedDate;

        }

        public ZeldaData() { }
    }

}
