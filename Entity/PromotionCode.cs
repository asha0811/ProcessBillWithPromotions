using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotions.Entity
{
    public class PromotionCode
    {
        public string PromoCode { get; set; }

        public List<CartItems> ItemsApplicable { get; set; }

        public double PromoPrice { get; set; }

        public bool IsActive { get; set; }

    }
}
