using System;

namespace MaskApi.models
{
    public class Order
    {

        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public Order(Mask mask, int qty) // order constructor
        {
            this.OrderNo = this.GenerateOrderNo();
            this.Mask = mask;
            this.Qty = qty;
            this.SetPrice();
        }
        public void SetPrice()
        {
            this.Price = this.Qty * Mask.Cost;
        }

        //creating random generator
        public int GenerateOrderNo()
        {
            Random rand = new Random();
            return rand.Next(1000, 10000);
        }
    }
}