using Application.Contracts;

namespace Application.Interfaces;

public interface IStickerService
{
    Task CreateAsync(CreateStickerRequest request);
}