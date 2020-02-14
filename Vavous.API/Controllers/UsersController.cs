using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vavous.API.Database;
using Vavous.API.Database.Entities;

namespace Vavous.API.Controllers {
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase {
        private readonly VavousCtx ctx;

        public UserController(VavousCtx ctx) {
            this.ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(ctx.User.Include(u => u.Company).ToList();
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login() {

            return Ok();
        }
    }
}