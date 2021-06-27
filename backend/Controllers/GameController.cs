using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Model;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public GameController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Game
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> Getgames()
        {
            return await _context.games.Include(p => p.page).ToListAsync();
        }

        // GET: api/Game/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(long id)
        {
            var game = await _context.games.Include(p => p.page).Where(p => p.GameId == id).FirstAsync();

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

        // PUT: api/Game/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(long id, Game game)
        {
            if (id != game.GameId)
            {
                return BadRequest();
            }

            var gameDb = _context.games.Include(p => p.page).Where(p => p.GameId == id).FirstOrDefault();

            gameDb.Name = game.Name;
            gameDb.Gender = game.Gender;
            gameDb.Description = game.Description;
            gameDb.Popularity = game.Popularity;
            gameDb.ImageLink = game.ImageLink;
            gameDb.Developer = game.Developer;

            gameDb.page.MainPage = game.page.MainPage;
            gameDb.page.Platforms = game.page.Platforms;
            gameDb.page.longDescription = game.page.longDescription;
            gameDb.page.LinkYoutube = game.page.LinkYoutube;
            gameDb.page.ReleaseNotes = game.page.ReleaseNotes;
            gameDb.page.Podcast = game.page.Podcast;

            _context.Entry(gameDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Game
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.games.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGame", new { id = game.GameId }, game);           
        }

        // DELETE: api/Game/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(long id)
        {
            var game = await _context.games.Include(p => p.page).Where(p => p.GameId == id).FirstOrDefaultAsync();
            if (game == null)
            {
                return NotFound();
            }

            _context.games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameExists(long id)
        {
            return _context.games.Any(e => e.GameId == id);
        }
    }
}
