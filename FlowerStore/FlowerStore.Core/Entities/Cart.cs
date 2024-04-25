using FlowerStore.Core.Entities;

namespace FlowerStore.Core 
{
    public class Cart : BaseEntity 
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public Cart(int userId, int productId, int quantity, double totalPrice)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}