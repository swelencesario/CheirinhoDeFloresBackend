using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Application.ViewModel
{
    public class CartViewModel
    {
        public CartViewModel(int userId, int productId, double totalPrice, int quantity)
        {
            UserId = userId;
            ProductId = productId;
            TotalPrice = totalPrice;
            Quantity = quantity;
        }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}