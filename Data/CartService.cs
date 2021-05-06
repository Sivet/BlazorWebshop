using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace BlazorWebshop.Data
{
    class CartService
    {
        private Cart currentCart;
        public event Action OnChange;
        public static int cartSize;

        public CartService(){
            currentCart = new Cart();
            cartSize = 0;
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
        public Task<List<Product>> GetCurrentCart(){
            return Task.FromResult(currentCart.Products);
        }
        public void Add(Product product){
            currentCart.Products.Add(product);
            cartSize = currentCart.Products.Count();
            Console.WriteLine("Cart Items:");
            foreach(var item in currentCart.Products){
                Console.WriteLine(item.Name);
            }
            NotifyStateChanged();
        }
        public void Remove(Product product){
            currentCart.Products.Remove(product);
            cartSize = currentCart.Products.Count();
            Console.WriteLine("Cart Items:");
            foreach(var item in currentCart.Products){
                Console.WriteLine(item.Name);
            }
            NotifyStateChanged();
        }
        public int GetCartSize(){
            return currentCart.Products.Count();
        }
    }
}