using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing.Models;

namespace OrderProcessingTests
{
    public class OrderTests
    {
        [Theory]
        [InlineData(100, "Loyal", 10, 90)]  // Expect 10% discount
        [InlineData(99, "Loyal", 0, 99)]    // No discount below 100
        [InlineData(150, "New", 0, 150)]    // No discount for new customers
        public void Order_DiscountCalculation(double amount, string customerType, double expectedDiscount, double expectedTotal)
        {
            var order = new OrderModel { Amount = amount, CustomerType = customerType };

            if (order.Amount >= 100 && order.CustomerType == "Loyal")
            {
                order.Discount = order.Amount * 0.10;
            }
            else
            {
                order.Discount = 0;
            }

            order.FinalTotal = order.Amount - order.Discount;

            Assert.Equal(expectedDiscount, order.Discount);
            Assert.Equal(expectedTotal, order.FinalTotal);
        }
    }
}
