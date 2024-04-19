using Application.Contracts;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services;

public class StickerService(IStickerRepository repository, IMapper mapping) : IStickerService
{
    public async Task CreateAsync(CreateStickerRequest request)
    {
        await repository.CreateAsync(mapping.Map<Sticker>(request));
    }
}