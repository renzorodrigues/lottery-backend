using System;
using System.Collections.Generic;

namespace lotteryBack.Domain.DTO
{
  public class GetGroupDetailedDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<GetUserForGroupDto> Users { get; set; }
  }
}