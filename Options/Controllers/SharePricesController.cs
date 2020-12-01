using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Options.Models;

namespace Options.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharePricesController : ControllerBase
    {
        private readonly OptionsDBContext _context;

        public SharePricesController(OptionsDBContext context)
        {
            _context = context;
        }

        internal void updateAllPrices()
        {
            throw new NotImplementedException();
        }

        // GET: api/SharePrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SharePrice>>> GetSharePrice()
        {
            return await _context.SharePrice.ToListAsync();
        }

        // GET: api/SharePrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SharePrice>> GetSharePrice(int id)
        {
            var sharePrice = await _context.SharePrice.FindAsync(id);

            if (sharePrice == null)
            {
                return NotFound();
            }

            return sharePrice;
        }

        // PUT: api/SharePrices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSharePrice(int id, SharePrice sharePrice)
        {
            if (id != sharePrice.Id)
            {
                return BadRequest();
            }

            _context.Entry(sharePrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SharePriceExists(id))
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

        // POST: api/SharePrices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SharePrice>> PostSharePrice(SharePrice sharePrice)
        {
            _context.SharePrice.Add(sharePrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSharePrice", new { id = sharePrice.Id }, sharePrice);
        }

        // DELETE: api/SharePrices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SharePrice>> DeleteSharePrice(int id)
        {
            var sharePrice = await _context.SharePrice.FindAsync(id);
            if (sharePrice == null)
            {
                return NotFound();
            }

            _context.SharePrice.Remove(sharePrice);
            await _context.SaveChangesAsync();

            return sharePrice;
        }

        private bool SharePriceExists(int id)
        {
            return _context.SharePrice.Any(e => e.Id == id);
        }
    }
}
