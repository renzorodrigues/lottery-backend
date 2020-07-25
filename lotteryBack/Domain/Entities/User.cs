using System;
using System.Collections.Generic;

namespace lotteryBack.Domain.Entities
{
  public class User
  {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
      public DateTime BirthDate { get; set; }
      public DateTime CreatedAt { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }
      public List<UserGroup> UserGroup { get; set; }
  }
}