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
  [Route("")]
  public class ApiRootController : ControllerBase
  {
    private readonly ILogger<ApiRootController> _logger;

    public ApiRootController(ILogger<ApiRootController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public ApiRootDto Get()
    {
      ApiRootDto apiRoot = new ApiRootDto{
        links=new List<LinkDto>() {
          new LinkDto{
            rel="root",
            href=Url.ActionLink("Get", "ApiRoot")
          },
          new LinkDto{
            rel="user",
            href=Url.ActionLink("Get", "User")
          },
          new LinkDto{
            rel="post",
            href=Url.ActionLink("Get", "Post")
          }
        }
      };

      return apiRoot;
    }
  }
}
