using System.Security.Claims;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[Authorize]
public class UsersController(IUserRepository userRepository) : BaseApiController
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        var users = await userRepository.GetMembersAsync();

        return Ok(users);

    }


    [HttpGet("{username}")]
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        var user = await userRepository.GetMemberAsync(username);

        if (user == null) return NotFound();
        return user;

    }

    [HttpPut]
    public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto, IMapper mapper)
    {
        var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (username == null) return BadRequest("No username found in token");
        var user = await userRepository.GetUserByNameAsync(username);
        if (user == null) return BadRequest("Coild not find user");
        mapper.Map(memberUpdateDto, user);
        if (await userRepository.SaveAllAsync()) return NoContent();
        return BadRequest("Fail to update user");
    }
}
