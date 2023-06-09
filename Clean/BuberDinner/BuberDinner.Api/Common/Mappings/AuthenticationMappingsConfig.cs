

using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Authentication.Common;
using BuberDinner.Application.Authentication.Queries.Login;
using BuberDinner.Contracts.Authentication;
using Mapster;

namespace BuberDinner.Api.Common.Mappings
{
    public class AuthenticationMappingsConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterCommand, RegisterRequest>();
            config.NewConfig<LoginQuery, LoginRequest>();
                
            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                            
                            .Map(dest => dest, src => src.User);
        }
    }
}