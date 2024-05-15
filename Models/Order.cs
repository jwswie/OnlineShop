namespace ASPNETMVCProject.Models
{
    public class Order
    {
        public int ORDER_ID {  get; set; }
        public int USER_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int Amount { get; set; }

        public Order(int orderId, int userId, int productId, int Amount)
        {
            this.ORDER_ID = orderId;
            this.USER_ID = userId;
            this.PRODUCT_ID = productId;
            this.Amount = Amount;
        }
    }
}
