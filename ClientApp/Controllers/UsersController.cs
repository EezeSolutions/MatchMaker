using ClientApp.Data;
using ClientApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // .com/api/users
    public class UsersController : ControllerBase
    {
        private readonly DbManager _context;

        public UsersController(DbManager context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IEnumerable<AppUser>> getallUsers()
        {
            var allUsers = await _context.Users.ToListAsync();

            return allUsers;
        }


        [HttpGet("{id}")]
        public async Task<AppUser> getUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}
