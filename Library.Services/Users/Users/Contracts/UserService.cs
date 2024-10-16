﻿using Library.Services.Users.Contracts.Dtos;

namespace Library.Services.Users.Contracts;

public interface UserService
{
    Task<int> CreateAsync(
        CreateUserDto userDto);

    Task<ShowUserDto?> GetById(int id);

    Task<IEnumerable<ShowAllUsersDto>>
        GetAll();

    Task Update(int id,UserUpdateDto dto);
    Task Delete(int id);
}