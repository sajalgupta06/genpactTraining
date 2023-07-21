using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstTestingApp
{
    public class Product<T>

    {
        List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void RemoveProduct(T product)
        {
            products.Remove(product);
        }
        public bool Contains(T product)
        {
            return products.Contains(product);
        }

        public int Count { get { return products.Count;} }
    }
}
