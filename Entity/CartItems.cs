using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessBillWithPromotions.Entity
{
    public class CartItems : CatalogueItems
    {
        public int Quantity { get; set; }

        public int PendingItmesForBilling { get; set; }
    }
}
