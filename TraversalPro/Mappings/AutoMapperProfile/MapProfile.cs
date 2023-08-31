using AutoMapper;
using DTOLayer.AnnouncementDto;
using DTOLayer.AppUserDto;
using DTOLayer.ContactDto;
using EntityLayer.Concrete;

namespace TraversalPro.Mappings.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDto, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDto, AppUser>().ReverseMap();

            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();

            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();
        }
    }
}
