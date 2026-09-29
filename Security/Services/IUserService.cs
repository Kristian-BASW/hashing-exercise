using DataAccess.Entities;

namespace Security.Services;

public interface IUserService
{
    bool TryLogin(User user);
    
    void TryRegister(User user);
}