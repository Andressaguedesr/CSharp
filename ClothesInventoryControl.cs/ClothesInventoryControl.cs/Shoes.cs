using System;
using System.Collections.Generic;
using System.Text;

namespace ClothesInventoryControl.cs
{
    public class Shoes
    {
        public Shoes (ShoesType type, string brand, int size, string color)
        {
            Type = type;
            Brand = brand;
            Size = size;
            Color = color;
        }

        public ShoesType Type { get; set; }
        
        public string Brand { get; set; }

        public int Size { get; set; }

        public string Color { get; set; }
    }
}