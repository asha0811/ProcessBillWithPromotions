using Moq;
using ProcessBillWithPromotions.DataAccess;
using ProcessBillWithPromotions.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProcessBillWithPromotionTest
{
    public class ProcessBillTest
    {
        ProcessBill _processBill;
        Mock<BillDAL> billDAL;
        public ProcessBill ProcessBillObj
        {
            get
            {
                if (_processBill == null)
                {
                    _processBill = new ProcessBill(billDAL.Object);
                }
                return _processBill;
            }
        }
        [Fact]
        public void ProcessFinalBillTest_Scenario_1()
        {
            //delegate List<CartItems> delegateMockGetCartItems();
            //MockBillDAL obj = new MockBillDAL();

            billDAL = new Mock<BillDAL>();
            billDAL.Setup(x => x.GetCartItems()).Returns(
                new List<CartItems>
                {
                    new CartItems { ItemId = "A", ItemName = "AAAA", PricePerUnit = 50, Quantity = 1 },
                    new CartItems { ItemId = "B", ItemName = "BBBB", PricePerUnit = 30, Quantity = 1 },
                    new CartItems { ItemId = "C", ItemName = "CCCC", PricePerUnit = 20, Quantity = 1 }
                });

            _processBill = ProcessBillObj;
            var result = _processBill.ProcessFinalBill();
            Assert.Equal(100, result);
        }

        [Fact]
        public void ProcessFinalBillTest_Scenario_2()
        {
            billDAL = new Mock<BillDAL>();
            billDAL.Setup(x => x.GetCartItems()).Returns(
                new List<CartItems>
                {
                    new CartItems { ItemId = "A", ItemName = "AAAA", PricePerUnit = 50, Quantity = 5 },
                    new CartItems { ItemId = "B", ItemName = "BBBB", PricePerUnit = 30, Quantity = 5 },
                    new CartItems { ItemId = "C", ItemName = "CCCC", PricePerUnit = 20, Quantity = 1 }
                });

            _processBill = ProcessBillObj;
            var result = _processBill.ProcessFinalBill();
            Assert.Equal(370, result);
        }


        [Fact]
        public void ProcessFinalBillTest_Scenario_3()
        {
            //delegate List<CartItems> delegateMockGetCartItems();
            //MockBillDAL obj = new MockBillDAL();

            billDAL = new Mock<BillDAL>();
            billDAL.Setup(x => x.GetCartItems()).Returns(
                new List<CartItems>
                {
                    new CartItems { ItemId = "A", ItemName = "AAAA", PricePerUnit = 50, Quantity = 3 },
                    new CartItems { ItemId = "B", ItemName = "BBBB", PricePerUnit = 30, Quantity = 5 },
                    new CartItems { ItemId = "C", ItemName = "CCCC", PricePerUnit = 20, Quantity = 1 },
                    new CartItems { ItemId = "D", ItemName = "DDDD", PricePerUnit = 15, Quantity = 1 }
                });

            _processBill = ProcessBillObj;
            var result = _processBill.ProcessFinalBill();
            Assert.Equal(280, result);
        }

        [Fact]
        public void ProcessFinalBillTest_Scenario_4()
        {
            billDAL = new Mock<BillDAL>();
            billDAL.Setup(x => x.GetCartItems()).Returns(
                new List<CartItems>
                {
                    new CartItems { ItemId = "A", ItemName = "AAAA", PricePerUnit = 50, Quantity = 7 },
                    new CartItems { ItemId = "B", ItemName = "BBBB", PricePerUnit = 30, Quantity = 3 },
                    new CartItems { ItemId = "C", ItemName = "CCCC", PricePerUnit = 20, Quantity = 2 },
                    new CartItems { ItemId = "D", ItemName = "DDDD", PricePerUnit = 15, Quantity = 3 }
                });

            _processBill = ProcessBillObj;
            var result = _processBill.ProcessFinalBill();
            Assert.Equal(460, result);
        }
    }
}
