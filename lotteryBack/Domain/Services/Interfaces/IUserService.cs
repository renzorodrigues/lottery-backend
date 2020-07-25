using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;

namespace lotteryBack.Domain.Services.Interfaces
{
  public interface IUserService
  {
    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task<User> Add(User user);
    Task<User> Update(int id);
    void Delete(User user);
  }
}