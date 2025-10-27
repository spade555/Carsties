using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

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
    }
}
