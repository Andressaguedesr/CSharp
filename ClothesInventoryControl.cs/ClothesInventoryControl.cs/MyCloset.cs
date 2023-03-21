using System;
using System.Collections.Generic;
using System.Text;

namespace ClothesInventoryControl.cs
{
    public class MyCloset
    {
        public List<Clothes> Clothes { get; set; }
        public List<Shoes> Shoes { get; set; }

        public MyCloset()
        {
            Clothes = new List<Clothes>();
            Shoes = new List<Shoes>();
        }

        public void AddClothes (Clothes clothes)
        {
            Clothes.Add(clothes);

        }

        public void AddShoes(Shoes shoes)
        {
            Shoes.Add(shoes);

        }
    }
    
}   
