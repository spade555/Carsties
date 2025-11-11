using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;
using Contracts;

namespace AuctionService.Mappers;

public class RequestMapper : Profile
{
    public RequestMapper()
    {
        // entity => DTO
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();

        // DTO => entity
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();

        // DTO => event
        CreateMap<AuctionDto, AuctionCreated>();

        // entity => event
        CreateMap<Auction, AuctionUpdated>().IncludeMembers(a => a.Item);
        CreateMap<Item, AuctionUpdated>();
    }
}
