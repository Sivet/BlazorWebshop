using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace BlazorWebshop.Data
{
    class ProductService
    {
        private Product currentProduct;

        public ProductService(){
            currentProduct = new Product();
        }
        public Task<Product> GetCurrentProduct(){
            return Task.FromResult(new Product(currentProduct));
        }
        public void SetCurrentProduct(string name){
            currentProduct.Name = name;
            //Find this in db
            currentProduct.Image = ImageService.GetSingleImg(name);
            currentProduct.Information = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }
    }
}