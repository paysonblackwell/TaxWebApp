using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxWebApp.Data;
using TaxWebApp.Models;

namespace TaxWebApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporatesController : ControllerBase
    {
        private readonly TaxDataContext _context;

        public CorporatesController(TaxDataContext context)
        {
            _context = context;
        }

        // GET: api/Corporates
        [HttpGet]
        public IEnumerable<Corporate> GetCorporate()
        {
            return _context.Corporate;
        }

        // GET: api/Corporates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCorporate([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var corporate = await _context.Corporate.FindAsync(id);

            if (corporate == null)
            {
                return NotFound();
            }

            return Ok(corporate);
        }

        // PUT: api/Corporates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorporate([FromRoute] long id, [FromBody] Corporate corporate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != corporate.Id)
            {
                return BadRequest();
            }

            _context.Entry(corporate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CorporateExists(id))
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

        // POST: api/Corporates
        [HttpPost]
        public async Task<IActionResult> PostCorporate([FromBody] Corporate corporate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Corporate.Add(corporate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCorporate", new { id = corporate.Id }, corporate);
        }

        // DELETE: api/Corporates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCorporate([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var corporate = await _context.Corporate.FindAsync(id);
            if (corporate == null)
            {
                return NotFound();
            }

            _context.Corporate.Remove(corporate);
            await _context.SaveChangesAsync();

            return Ok(corporate);
        }

        private bool CorporateExists(long id)
        {
            return _context.Corporate.Any(e => e.Id == id);
        }
    }
}