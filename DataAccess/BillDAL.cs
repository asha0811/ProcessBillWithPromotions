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
