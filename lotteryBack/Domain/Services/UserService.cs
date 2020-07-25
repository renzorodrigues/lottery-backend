using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;
using lotteryBack.Domain.Services.Interfaces;

namespace lotteryBack.Domain.Services
{
  public class UserService : IUserService
  {
    private readonly IUserRepository repo;
    public UserService(IUserRepository repo)
    {
      this.repo = repo;
    }

    public Task<IEnumerable<User>> GetAll()
    {
      var users = repo.GetAll();
      return users;
    }

    public Task<User> GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    public async Task<User> Add(User user)
    {
      var userAdded = await repo.Add(user);
      return userAdded;
    }

    public Task<User> Update(int id)
    {
      throw new System.NotImplementedException();
    }
    public void Delete(User user)
    {
      throw new System.NotImplementedException();
    }
  }
}