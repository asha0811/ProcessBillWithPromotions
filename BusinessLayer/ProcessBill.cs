using ProcessBillWithPromotions.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotions.DataAccess
{
    public class ProcessBill : IProcessBill
    {
        public BillDAL _billDAL;
        public ProcessBill(BillDAL objDAL)
        {
            if (objDAL == null)
            {
                _billDAL = new BillDAL();
            }
            else
            {
                _billDAL = objDAL;
            }

        }
        public double ProcessFinalBill()
        {
            double FinalBillAmount = 0;
            List<PromotionCode> promoList = _billDAL.GetActivePromotion();
            List<CartItems> cartList = _billDAL.GetCartItems();
            cartList.ForEach(item => item.PendingItmesForBilling = item.Quantity);

            try
            {
                foreach (var promo in promoList)
                {
                    bool promotionApplicable = true;
                    if (promo.ItemsApplicable != null)
                    {
                        while (promotionApplicable)
                        {
                            foreach (var promoItem in promo.ItemsApplicable)
                            {
                                if (!cartList.Exists(item => item.ItemId == promoItem.ItemId && item.PendingItmesForBilling >= promoItem.Quantity))
                                {
                                    promotionApplicable = false;
                                }
                            }
                            if (promotionApplicable)
                            {
                                foreach (var promoItem in promo.ItemsApplicable)
                                {
                                    int indexForCartItem = cartList.FindIndex(item => item.ItemId == promoItem.ItemId);
                                    CartItems cartItem = cartList[indexForCartItem];
                                    cartItem.PendingItmesForBilling -= promoItem.Quantity;
                                }
                                FinalBillAmount += promo.PromoPrice;

                            }

                        }
                    }
                }


                foreach (var item in cartList)
                {
                    if (item.PendingItmesForBilling > 0)
                    {
                        FinalBillAmount += item.PendingItmesForBilling * item.PricePerUnit;
                        item.PendingItmesForBilling = 0;
                    }
                }
            }
            catch(NullReferenceException nullException)
            {
                Console.WriteLine(nullException.InnerException.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.InnerException.ToString());
            }
            return FinalBillAmount;
        }
    }
}
