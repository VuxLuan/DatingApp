using API.DTOs;
using API.Entities;

namespace API.Interfaces;

public interface IUserMappingService
{
    MemberDto? MapToMemberDto(AppUser user);
}
