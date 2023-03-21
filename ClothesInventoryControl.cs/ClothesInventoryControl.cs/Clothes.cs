using System;
using System.Collections.Generic;
using System.Text;

namespace ClothesInventoryControl.cs
{
    public class Clothes
    {
        public Clothes (ClothesType type, string size, string color, string modeling)
        {
            Type = type;
            Size = size;
            Color = color;
            Modeling = modeling;
        }

        public ClothesType Type { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Modeling { get; set; }   
    
    }
}
