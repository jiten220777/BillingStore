namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string HSNCode { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public long PurchaseRate { get; set; }
        public long SaleRate { get; set; }
        public long CGST { get; set; }
        public long SGST { get; set; }
        public long IGST { get; set; }
        public long ReorderLevel { get; set; }

    }
}