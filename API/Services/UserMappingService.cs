// using System;
// using API.DTOs;
// using API.Entities;
// using API.Extensions;
// using API.Interfaces;

// namespace API.Services;

// public class UserMappingService : IUserMappingService
// {
//     public MemberDto? MapToMemberDto(AppUser user)
//     {
//         if (user == null) return null;

//         return new MemberDto
//         {
//             Id = user.Id,
//             Username = user.UserName,
//             Age = user.DateOfBirth.CalculateAge(), 
//             PhotoUrl = user.Photos.FirstOrDefault()?.Url, 
//             KnownAs = user.KnownAs,
//             Created = user.Created,
//             LastActive = user.LastActive,
//             Gender = user.Gender,
//             Introduction = user.Introduction,
//             Interests = user.Interests,
//             LookingFor = user.LookingFor,
//             City = user.City,
//             Country = user.Country,
//             Photos = user.Photos.Select(p => new PhotoDto
//             {
//                 Id = p.Id,
//                 Url = p.Url,
//                 // Map other properties as necessary
//             }).ToList()
//         };
//     }
// }
