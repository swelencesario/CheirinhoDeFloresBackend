using FlowerStore.Core;
using FlowerStore.Core.Entities;

namespace FlowerStore.Entities
{
    public class Flower : BaseEntity
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; private set; }
        public Category? Category { get; set; }

        public Flower(string description, double price, string imageUrl, int categoryId)
        {
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
        }
    }
}

