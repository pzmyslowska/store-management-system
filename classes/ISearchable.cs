using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal interface ISearchable
    {
        void Search(List<Product> products);
        void categoryFilter(List<Product> products);
        void customerInfo();
        void managerInfo();
        void customerShowAll(List<Product> products);
        void managerShowAll(List<Product> products);
    }
}