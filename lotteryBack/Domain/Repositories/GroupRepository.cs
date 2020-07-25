using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lotteryBack.Data;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lotteryBack.Domain.Repositories
{
  public class GroupRepository : IGroupRepository
  {
    private readonly DataContext context;
    public GroupRepository(DataContext context)
    {
      this.context = context;
    }
    public async Task<IEnumerable<Group>> GetAll()
    {
      var groups = await context.Groups
      .AsNoTracking()
      .Include(ug => ug.UserGroup).ThenInclude(u => u.User)
      .ToListAsync();
      return groups;
    }

    public async Task<Group> GetById(int id)
    {
      var group = await context.Groups
      .AsNoTracking()
      .Include(ug => ug.UserGroup).ThenInclude(u => u.User)
      .FirstOrDefaultAsync(g => g.Id == id);
      return group;
    }

    public Task<Group> Update(int id)
    {
      throw new System.NotImplementedException();
    }

    public async Task<Group> Add(Group group)
    {
      await context.Groups.AddAsync(group);
      await context.SaveChangesAsync();
      return group;
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}