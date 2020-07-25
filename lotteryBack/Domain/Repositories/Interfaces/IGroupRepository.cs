using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;

namespace lotteryBack.Domain.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetAll();
         Task<Group> GetById(int id);
         Task<Group> Add(Group group);
         Task<Group> Update(int id);
         void Delete(int id);
    }
}