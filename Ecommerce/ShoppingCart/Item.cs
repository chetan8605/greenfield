using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Item
    {
        public List<Item> Items {  get; set; }  
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
