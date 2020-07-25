using System;
using System.Collections.Generic;

namespace lotteryBack.Domain.DTO
{
    public class GetGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}