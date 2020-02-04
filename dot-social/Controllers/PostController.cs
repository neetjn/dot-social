using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dot_social.Models;

namespace dot_social.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PostController : ControllerBase
  {
    private readonly ILogger<PostController> _logger;

    public PostController(ILogger<PostController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public PostDto Get()
    {
      PostDto postDto = new PostDto{};
      return postDto;
    }
  }
}
