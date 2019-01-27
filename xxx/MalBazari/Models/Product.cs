using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalBazari.Models
{
    public class Product
    {
        public int productId = -1;
        public string productName = "";
        public Product(int productId, string productNama)
        {
            this.productId = productId;
            this.productName = productNama;
        }
        public Product GetProduct
        {
            get { return this; }
        }
    }
}
