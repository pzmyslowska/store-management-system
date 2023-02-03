using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class BodyProduct : Product
    {
        public BodyProduct(int productID, long code, string name, double price, byte tax, double weight, double volume, short shopQuantity, short warehouseQuantity) : base(productID, code, name, price, tax, weight, volume, shopQuantity, warehouseQuantity)
        {

        }
    }
}
