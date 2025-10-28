namespace FarmConnectMini.Models
{
    public class Crop
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Seller { get; set; } = "";
    }
}
