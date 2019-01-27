using System;
using System.Collections.Generic;
using System.Text;
using Core.Entityes;

namespace Entities.Congrete
{
    public class Product: IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }

    }
}
