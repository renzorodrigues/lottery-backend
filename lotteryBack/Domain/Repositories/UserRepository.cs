using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Data;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lotteryBack.Domain.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly DataContext context;
    public UserRepository(DataContext context)
    {
      this.context = context;
    }
    public async Task<IEnumerable<User>> GetAll()
    {
      var users = await context.Users.Include(g => g.UserGroup).ToListAsync();
      return users;
    }

    public Task<User> GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    public async Task<User> Add(User user)
    {
      await context.Users.AddAsync(user);
      await context.SaveChangesAsync();
      return user;
    }

    public Task<User> Update(int id)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}