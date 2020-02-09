using ConsoleAppProduct.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            productBusiness.start();
        }
    }
}
