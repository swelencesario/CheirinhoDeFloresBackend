using System;
using FlowerStore.Core.Entities;

namespace FlowerStore.Core
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }

        public Category(string description)
        {
            Description = description;
        }
    }
}
