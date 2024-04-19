using Domain.Entities;

namespace Domain.Repositories;

public interface IStickerRepository
{
    Task CreateAsync(Sticker sticker);
}
