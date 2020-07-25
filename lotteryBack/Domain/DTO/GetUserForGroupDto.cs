using System;
using System.Collections.Generic;

namespace lotteryBack.Domain.DTO
{
    public class GetUserForGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}