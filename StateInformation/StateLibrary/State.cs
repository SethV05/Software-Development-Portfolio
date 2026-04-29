using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary
{
    public class State
    {
        public int Id { get; set; }
        public string State_Name { get; set; } = "";
        public long Population { get; set; }
        public string Flag_Description { get; set; } = "";
        public string Flower { get; set; } = "";
        public string Bird { get; set; } = "";
        public string Colors { get; set; } = "";
        public string Largest_Cities { get; set; } = "";
        public string Capitol { get; set; } = "";
        public int Median_Income { get; set; }
        public double Percentage_Tech_Jobs { get; set; }
    }
}
