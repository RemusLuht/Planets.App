using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string HeroImage { get; set; }
        public string Description { get; set; }
        public Microsoft.Maui.Graphics.Color AccentColorStart { get; set; }
        public Microsoft.Maui.Graphics.Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }
    }
}
