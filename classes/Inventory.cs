using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Inventory
    {
        public int stockLevel(Product product)
        {
            return product.shopQuantity + product.warehouseQuantity;
        }

        public int allStock(List<Product> products)
        {
            int sum = 0;
            for (int i = 0; i < products.Count; i++)
            {
                sum += products[i].shopQuantity + products[i].warehouseQuantity;
            }
            return sum;
        }
    }
}
