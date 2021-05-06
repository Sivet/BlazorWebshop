using System;
using System.Collections.Generic;

namespace BlazorWebshop.Data
{
    public class Cart
    {
        public Cart(){
            Products = new List<Product>();
        }
        public List<Product> Products;
    }
}