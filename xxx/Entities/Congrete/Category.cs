using System;
using System.Collections.Generic;
using System.Text;
using Core.Entityes;

namespace Entities.Congrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
