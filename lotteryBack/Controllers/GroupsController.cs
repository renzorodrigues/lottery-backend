using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using lotteryBack.Domain.DTO;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lotteryBack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class GroupsController : ControllerBase
  {
    private readonly ILogger<GroupsController> logger;
    private readonly IGroupService service;
    private readonly IMapper mapper;

    public GroupsController(ILogger<GroupsController> logger, IGroupService service, IMapper mapper)
    {
      this.logger = logger;
      this.service = service;
      this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var groups = await service.GetAll();
      var groupsToReturn = mapper.Map<IEnumerable<GetGroupDto>>(groups);
      return Ok(groupsToReturn);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var group = await service.GetById(id);
      var groupToReturn = mapper.Map<GetGroupDetailedDto>(group);
      return Ok(groupToReturn);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(Group group)
    {
      var groupAdded = await service.Add(group);
      return StatusCode(201);

    }
  }
}