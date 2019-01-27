using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulutWebApi.Models
{
    public class Product
    {
        public int productid { get; set; }
        public string productName { get; set; }
        public decimal productPrice { get; set; }
    }
}
