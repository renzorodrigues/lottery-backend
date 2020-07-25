using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;

namespace lotteryBack.Domain.Services.Interfaces
{
  public interface IGroupService
  {
    Task<IEnumerable<Group>> GetAll();
    Task<Group> GetById(int id);
    Task<Group> Add(Group group);
    Task<Group> Update(int id);
    void Delete<Group>(Group group);
  }
}