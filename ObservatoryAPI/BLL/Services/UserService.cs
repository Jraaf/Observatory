﻿using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ObservatoryAPI.BLL.Services;

public class UserService(IUserRepository _repo, IConfiguration _config, IMapper _mapper) : IUserService
{
    public async Task<UserDTO> Login(LoginUserDTO dto)
    {
        var user = await _repo.GetByUsername(dto.Username);

        if (user == null)
        {
            throw new NotFoundException(dto.Username);
        }

        var hmac = new HMACSHA512(user.PasswordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password));

        for (int i = 0; i < computedHash.Length; i++)
        {
            if (computedHash[i] != user.PasswordHash[i])
                throw new Exception("Wrong password");
        }
        var endUser = new UserDTO()
        {
            Id = user.Id,
            Username = user.Username,
            AccessToken = CreateToken(user),
        };
        return endUser;
    }

    public async Task<UserDTO> Register(CreateUserDTO dto)
    {
        if (await _repo.UserExists(dto.Username))
        {
            throw new Exception($"{dto.Username} already taken");
        }

        using var hmac = new HMACSHA512();

        User user = new User()
        {
            Username = dto.Username,
            IsAdmin = dto.IsAdmin,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password)),
            PasswordSalt = hmac.Key
        };

        var endUser = _mapper.Map<UserDTO>(await _repo.AddAsync(user));

        endUser.AccessToken = CreateToken(user);
        return endUser;
    }

    public string CreateToken(User dto)
    {
        var tokenKey = _config["TokenKey"] ?? throw new Exception("cannot access token key");
        if (tokenKey.Length < 64) throw new Exception("too short key");

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

        var claims = new List<Claim>
        {
            new (ClaimTypes.NameIdentifier, dto.Id.ToString()),
            new(ClaimTypes.Role, dto.IsAdmin ? "Admin" : "User")
        };

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(180),
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }

    public async Task<bool> UserExists(string username)
    {
        return await _repo.UserExists(username);
    }

    public async Task<User> GetMe(int userId)
    {
        return await _repo.GetMe(userId);
    }
}
