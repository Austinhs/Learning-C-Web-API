using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vavous.API.Database;
using Vavous.API.Database.Entities;

namespace Vavous.API.Controllers {
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase {
        private readonly VavousCtx _ctx;

        public TestController(VavousCtx ctx) {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Get() {
            _ctx.Add(new User {
                Email = "Test2@test.com",
                FirstName = "Rob",
                LastName = "Stanfield",
                Password = "3211",
                Company = new Company {
                    Name = "Stanfield.com",
                    Active = true,
                    OwnerId = 1
                }
            });

            _ctx.SaveChanges();

            var result = _ctx.User
                .Include(u => u.Company)
                .ToList();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

            var findUser = _ctx.User.FirstOrDefault(u => u.Id == id);

            _ctx.Remove(findUser);
            _ctx.SaveChanges();

            return NoContent();
        }

        [HttpDelete("all")]
        public IActionResult DeleteAll() {
            var allUsers = _ctx.User.Include(u => u.Company).ToList();

            foreach (User record in allUsers) {
                _ctx.Remove(record);
            }

            _ctx.SaveChanges();

            return NoContent();
        }
    }
}
