using ProcessBillWithPromotions.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotionTest
{
    class MockBillDAL
    {
        public List<CartItems> MockGetCartItems()
        {
            //write code to access data from source db
            List<CartItems> cart1 = new List<CartItems>();
            cart1.Add(new CartItems { ItemId = "A", ItemName = "AAAA", PricePerUnit = 50, Quantity = 7 });
            cart1.Add(new CartItems { ItemId = "B", ItemName = "BBBB", PricePerUnit = 30, Quantity = 3 });
            cart1.Add(new CartItems { ItemId = "C", ItemName = "CCCC", PricePerUnit = 20, Quantity = 2 });
            cart1.Add(new CartItems { ItemId = "D", ItemName = "DDDD", PricePerUnit = 15, Quantity = 3 });

            return cart1;
        }
    }
}
