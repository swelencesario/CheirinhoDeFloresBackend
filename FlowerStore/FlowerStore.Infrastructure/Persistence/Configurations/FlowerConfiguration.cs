using FlowerStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowerStore.Infrastructure.Persistence.Configurations
{
    public class FlowerConfiguration : IEntityTypeConfiguration<Flower>
    {
        public void Configure(EntityTypeBuilder<Flower> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .HasOne(f => f.Category)
                .WithOne()
                .HasForeignKey<Flower>(f => f.Id);
        }
    }
}

