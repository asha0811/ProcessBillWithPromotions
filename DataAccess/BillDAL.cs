using ProcessBillWithPromotions.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotions.DataAccess
{
    public class BillDAL : IBillDAL
    {
        public List<PromotionCode> GetActivePromotion()
        {

            //Write Code to get data fro source DB
            List<PromotionCode> promotion = new List<PromotionCode>();
            promotion.Add(new PromotionCode { PromoCode = "3A", IsActive = true, PromoPrice = 130 });
            promotion[0].ItemsApplicable = new List<CartItems>();
            promotion[0].ItemsApplicable.Add(new CartItems { ItemId = "A", Quantity = 3 });

            promotion.Add(new PromotionCode { PromoCode = "2B", IsActive = true, PromoPrice = 45 });
            promotion[1].ItemsApplicable = new List<CartItems>();
            promotion[1].ItemsApplicable.Add(new CartItems { ItemId = "B", Quantity = 2 });

            promotion.Add(new PromotionCode { PromoCode = "CD", IsActive = true, PromoPrice = 30 });
            promotion[2].ItemsApplicable = new List<CartItems>();
            promotion[2].ItemsApplicable.Add(new CartItems { ItemId = "C", Quantity = 1 });
            promotion[2].ItemsApplicable.Add(new CartItems { ItemId = "D", Quantity = 1 });

            return promotion;
        }

        public virtual List<CartItems> GetCartItems()
        {
            //write code to access data from source db
            List<CartItems> cart1 = new List<CartItems>();

            return cart1;
        }
    }
}
