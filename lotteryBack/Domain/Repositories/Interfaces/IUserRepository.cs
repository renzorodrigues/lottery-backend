using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;

namespace lotteryBack.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
         Task<User> GetById(int id);
         Task<User> Add(User user);
         Task<User> Update(int id);
         void Delete(int id);
    }
}