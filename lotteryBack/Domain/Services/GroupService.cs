using System.Collections.Generic;
using System.Threading.Tasks;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;
using lotteryBack.Domain.Services.Interfaces;

namespace lotteryBack.Domain.Services
{
  public class GroupService : IGroupService
  {
    private readonly IGroupRepository repo;
    public GroupService(IGroupRepository repo)
    {
      this.repo = repo;
    }

    public async Task<IEnumerable<Group>> GetAll()
    {
      var groups = await repo.GetAll();
      return groups;
    }

    public async Task<Group> GetById(int id)
    {
      var group = await repo.GetById(id);
      return group;
    }

    public async Task<Group> Add(Group group)
    {
      var groupAdded = await repo.Add(group);
      return groupAdded;
    }

    public Task<Group> Update(int id)
    {
      throw new System.NotImplementedException();
    }

    public void Delete<Group>(Group group)
    {
      throw new System.NotImplementedException();
    }
  }
}