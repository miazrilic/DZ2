using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_PREIMENOVANJE
{
    internal class Zad2preim
    {
        class ProductManager
        {

            List<Product> products;

            public ProductManager(List<Product> inventory)
            {
                products = inventory;
            }

            public void Restock(Product product)
            {
                foreach (Product prod in products)
                {
                    if (product == prod)
                        product.InStock = true;
                }
            }
            public void RemoveFromStock()
            {
                products.RemoveAll(product => product.InStock == false);
            }

        }
        class Product
        {

            public string Name { get; private set; }
            public string Price { get; private set; }
            public bool InStock { get; set; }

            public Product(string name, string price)
            {
                this.Name = name;
                this.Price = price;
                this.InStock = false;
            }

        }
    }
}
