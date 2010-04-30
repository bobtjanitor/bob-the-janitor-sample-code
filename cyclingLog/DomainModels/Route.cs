using System;

namespace DomainModels
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public string Location { get; set; }
        public DateTime LastTimeRidden { get; set; }
    }
}