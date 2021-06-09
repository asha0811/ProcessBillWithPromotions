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
          
            return FinalBillAmount;
        }
    }
}
