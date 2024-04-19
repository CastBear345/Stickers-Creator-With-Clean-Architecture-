using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class StickerConfiguration : IEntityTypeConfiguration<Sticker>
{
    public void Configure(EntityTypeBuilder<Sticker> builder)
    {
        builder
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(s => s.Url)
            .HasMaxLength(300)
            .IsRequired();
    }
}
