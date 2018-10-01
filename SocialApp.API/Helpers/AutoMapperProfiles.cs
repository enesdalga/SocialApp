using System.Linq;
using AutoMapper;
using SocialApp.API.Dtos;
using SocialApp.API.Models;

namespace SocialApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(x => x.PhotoUrl, opt =>
                {
                    opt.MapFrom(sourceMember => sourceMember.Photos
                    .FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt =>
                {
                    opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<User, UserForDetailDto>()
                   .ForMember(x => x.PhotoUrl, opt =>
                   {
                       opt.MapFrom(sourceMember => sourceMember.Photos
                       .FirstOrDefault(p => p.IsMain).Url);
                   })
                    .ForMember(dest => dest.Age, opt =>
                    {
                        opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                    });
            CreateMap<Photo, PhotosForDetailDto>();

        }
    }
}