using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldOfWarcraftBestInSlotWebApiApplication.Data;
using WorldOfWarcraftBestInSlotWebApiApplication.Models;

namespace WorldOfWarcraftBestInSlotWebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly PostgresqlDbService _context;

        public ItemsController(PostgresqlDbService context)
        {
            _context = context;
        }


        // GET: api/Items/all
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Item>>> GetAllItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }




        // GET: api/Items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems([FromQuery] string? category, [FromQuery] string? name)
        {
            var query = _context.Items.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(i => i.Category.Name == category);
            }

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(i => EF.Functions.ILike(i.Name, $"%{name}%"));
            }

            var items = await query.ToListAsync();
            return Ok(items);
        }



        // GET: api/Monsters
        [HttpGet("monsters")]
        public async Task<ActionResult<IEnumerable<Monster>>> GetMonsters()
        {
            var monsters = await _context.Monsters.ToListAsync();
            return Ok(monsters);
        }







    }
}