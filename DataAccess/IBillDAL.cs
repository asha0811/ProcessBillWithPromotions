using ProcessBillWithPromotions.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotions.DataAccess
{
    public interface IBillDAL
    {
        List<PromotionCode> GetActivePromotion();

        List<CartItems> GetCartItems();

    }
}
