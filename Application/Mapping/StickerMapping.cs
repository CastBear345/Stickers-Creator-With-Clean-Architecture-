using Application.Contracts;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping;

public class StickerMapping : Profile
{
    public StickerMapping()
    {
        CreateMap<Sticker, CreateStickerRequest>().ReverseMap();
    }
}
