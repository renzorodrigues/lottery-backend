using System;
using System.Collections.Generic;

namespace lotteryBack.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<UserGroup> UserGroup { get; set; }
    }
}