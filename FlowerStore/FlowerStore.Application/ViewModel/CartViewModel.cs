using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Application.ViewModel
{
    public class CartViewModel
    {
        public CartViewModel(int userId, int productId, string productName, string url, double totalPrice, int quantity, double unitPrice)
        {
            UserId = userId;
            ProductId = productId;
            ProductName = productName;
            Url = url;
            TotalPrice = totalPrice;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Url { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}