namespace MaskApi.models
{
    public class Mask
    {
        public string MaskId { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }
        public bool New { get; set; }
        public bool PreInfected { get; set; }
        public string Design { get; set; }
        public bool Reusable { get; set; }
        public double Cost { get; set; }
    }
}