using System;

namespace BlazorWebshop.Data
{
    public class Product
    {
        public Product(){

        }
        public Product(Product prod){
            Name = prod.Name;
            Image = prod.Image;
            Information = prod.Information;
        }
        public string Name { get; set; }
        public Img Image { get; set; }
        public string Information { get; set; }
    }
}