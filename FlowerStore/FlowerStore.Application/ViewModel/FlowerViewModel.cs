namespace FlowerStore.Application.ViewModel
{
    public class FlowerViewModel
    {
        public int FlowerId { get; private set; }
        public string FlowerName { get; private set; }
        public double Price { get; private set; }
        public string ImageUrl { get; private set; }

        public FlowerViewModel(int flowerId, string flowerName, double price, string imageUrl)
        {
            FlowerId = flowerId;
            FlowerName = flowerName;
            Price = price;
            ImageUrl = imageUrl;
        }

        public FlowerViewModel(int id)
        {
            FlowerId = id;
        }
    }
}

