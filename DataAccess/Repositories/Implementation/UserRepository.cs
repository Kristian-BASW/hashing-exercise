using DataAccess.Entities;

namespace DataAccess.Repositories;

public class UserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public User? GetUserByUsername(string username)
    {
        return _dbContext.Users.Where(x => x.Username == username)
            .FirstOrDefault();
            
    }
}