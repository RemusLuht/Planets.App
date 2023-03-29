using System;
using System.Collections.Generic;
using System.Text;

namespace Planets.Models
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
    //Background
        public Brush Background
        {
            get
            {
                var gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(AccentColorStart, 0.0f));
                gradientStops.Add(new GradientStop(AccentColorEnd, 1.0f));

                var bgBrush = new LinearGradientBrush(gradientStops,
                    new Point(0.0, 0.0),
                    new Point(1.0, 1.0));

                return bgBrush;
            }
        }
    }

}
