using Catalogue.AuthenticationService.DTOs;

namespace Catalogue.AuthenticationService.Interfaces
{
    public interface IUserRepository
    {
        UserDto AuthenticateUser(LoginRequestDto loginRequestDto);
        bool CreateUser(CreateUserDto createUserDto);
        bool IsUserExisting(string email);
    }
}
