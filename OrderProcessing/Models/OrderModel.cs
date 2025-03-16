namespace OrderProcessing.Models
{
    public class OrderModel
    {
        public double Amount { get; set; }
        public string CustomerType { get; set; }
        public double Discount { get; set; }
        public double FinalTotal { get; set; }
    }
}
