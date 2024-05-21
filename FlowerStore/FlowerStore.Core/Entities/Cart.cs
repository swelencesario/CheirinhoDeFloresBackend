using FlowerStore.Core.Entities;

namespace FlowerStore.Core 
{
    public class Cart : BaseEntity 
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Url { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set;}
        public double TotalPrice { get; set; }

        public Cart(int userId, int productId, string productName, string url, int quantity, double unitPrice, double totalPrice)
        {
            UserId = userId;
            ProductId = productId;
            ProductName = productName;
            Url = url;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
    }
}