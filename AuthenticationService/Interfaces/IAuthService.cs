using Catalogue.AuthenticationService.DTOs;

namespace Catalogue.AuthenticationService.Interfaces
{
    public interface IAuthService
    {
        Task<GenericResponse<LoginResponse>> Login(LoginRequestDto loginRequestDto);
        Task<GenericResponse<SignUpResponse>> SignUp(SignUpRequest signRequest);
    }
}
