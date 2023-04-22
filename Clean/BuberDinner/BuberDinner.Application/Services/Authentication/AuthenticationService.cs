using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;
using FluentResults;

namespace BuberDinner.Application.Services.Authentication;


public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResult Login(string email, string password)
    {
        // 1. Validate user exists
        if(_userRepository.GetUserByEmail(email) is not User user) 
        {
            throw new Exception("Incorrect email or password");
        }
        // 2. Validate password
        if(user.Password != password)
        {
            throw new Exception("Incorrect email or password");
        }

        // 3. Generate Token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }

    public Result<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        // 1. Validate user doesnt exist
        if(_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }

        // 2. Create user (generate unique id) and save to db
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };
        _userRepository.Add(user);

        // Generate Token

        
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);

    }
}