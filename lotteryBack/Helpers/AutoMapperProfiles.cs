using System.Linq;
using AutoMapper;
using lotteryBack.Domain.DTO;
using lotteryBack.Domain.Entities;

namespace lotteryBack.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, GetUserForGroupDto>();
            CreateMap<Group, GetGroupDto>();
            CreateMap<Group, GetGroupDetailedDto>()
                .ForMember(dto => dto.Users, ug => ug.MapFrom(ug => ug.UserGroup.Select(u => u.User)));
        }
    }
}