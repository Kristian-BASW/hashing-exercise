using DataAccess.Entities;
using DataAccess.Repositories;

namespace Security.Services.Implementation;

public class UserService: IUserService
{
    private readonly IUserRepository _userRepo;

    public UserService(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }
    public bool TryLogin(User user)
    {
        return _userRepo.GetUserByUsername(user.Username).Password == user.Password;
    }

    public void TryRegister(User user)
    {
        _userRepo.CreateUser(user);
    }
}