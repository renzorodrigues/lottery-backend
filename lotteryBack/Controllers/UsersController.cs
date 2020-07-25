using System.Threading.Tasks;
using AutoMapper;
using lotteryBack.Domain.Entities;
using lotteryBack.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lotteryBack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly ILogger<UsersController> logger;
    private readonly IUserService service;
    private readonly IMapper mapper;

    public UsersController(ILogger<UsersController> logger, IUserService service, IMapper mapper)
    {
      this.logger = logger;
      this.service = service;
      this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var users = await service.GetAll();
      return Ok(users);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
      var userAdded = await service.Add(user);
      return StatusCode(201);

    }
  }
}