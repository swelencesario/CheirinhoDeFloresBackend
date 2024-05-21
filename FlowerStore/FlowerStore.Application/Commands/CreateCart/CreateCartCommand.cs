using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace FlowerStore.Application.Commands.CreateCart
{
    public class CreateCartCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Url { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double UnitPrice { get; set; }
        
    }
}