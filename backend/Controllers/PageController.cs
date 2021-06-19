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
    public class PageController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PageController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Page
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> Getpages()
        {
            return await _context.pages.ToListAsync();
        }

        // GET: api/Page/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Page>> GetPage(long id)
        {
            var page = await _context.pages.FindAsync(id);

            if (page == null)
            {
                return NotFound();
            }

            return page;
        }

        // PUT: api/Page/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPage(long id, Page page)
        {
            if (id != page.PageId)
            {
                return BadRequest();
            }

            _context.Entry(page).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PageExists(id))
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

        // POST: api/Page
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Page>> PostPage(Page page)
        {
            _context.pages.Add(page);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPage", new { id = page.PageId }, page);
        }

        // DELETE: api/Page/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePage(long id)
        {
            var page = await _context.pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            _context.pages.Remove(page);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PageExists(long id)
        {
            return _context.pages.Any(e => e.PageId == id);
        }
    }
}
