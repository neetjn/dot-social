﻿using System;
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
  public class UserController : ControllerBase
  {
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public UserPublicDto Get()
    {
      UserPublicDto userDto = new UserPublicDto{};
      return userDto;
    }
  }
}
