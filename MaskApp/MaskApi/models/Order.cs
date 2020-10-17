namespace MaskApi.models
{
    public class Order
    {
        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
}