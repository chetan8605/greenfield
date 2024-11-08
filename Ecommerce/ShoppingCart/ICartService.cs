using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal interface ICartService
    {
        List<Item> GetCart();
        bool AddToCart(Item item);
        bool RemoveFromCart(Item item);
        bool Clear();
    }
}
