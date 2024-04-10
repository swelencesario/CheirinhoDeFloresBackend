namespace FlowerStore.Application.ViewModel
{
    public class FlowerViewModel
    {
        public string FlowerName { get; private set; }

        public FlowerViewModel(string flowerName)
        {
            FlowerName = flowerName;
        }
    }
}

