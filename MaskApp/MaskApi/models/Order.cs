namespace MaskApi.models
{
    public class Order
    {

        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public Order(int orderNo, Mask mask, int qty, double price) //constructor
        {
            OrderNo = orderNo;
            Mask = mask;
            Qty = qty;
            Price = price;
        }
        public void SetPrice() {
            this.Price = this.Qty * Mask.Cost;
        }
    }
}