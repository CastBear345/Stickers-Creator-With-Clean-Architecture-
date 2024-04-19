using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

internal class StickerRepository(AppDbContext dbContext) : IStickerRepository
{
    public async Task CreateAsync(Sticker request)
    {

        await dbContext.Stickers.AddAsync(request);
        await dbContext.SaveChangesAsync();
    }
}