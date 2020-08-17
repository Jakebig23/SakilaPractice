using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SakilaPractice.Data;
using SakilaPractice.Models;

namespace SakilaPractice.Controllers
{
    public class film_actorController : Controller
    {
        private readonly SakilaPracticeContext _context;

        public film_actorController(SakilaPracticeContext context)
        {
            _context = context;
        }

        // GET: film_actor
        public async Task<IActionResult> Index()
        {
            return View(await _context.film_actor.ToListAsync());
        }

        // GET: film_actor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_actor = await _context.film_actor
                .FirstOrDefaultAsync(m => m.actor_id == id);
            if (film_actor == null)
            {
                return NotFound();
            }

            return View(film_actor);
        }

        // GET: film_actor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: film_actor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("actor_id,film_id,last_update")] film_actor film_actor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film_actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film_actor);
        }

        // GET: film_actor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_actor = await _context.film_actor.FindAsync(id);
            if (film_actor == null)
            {
                return NotFound();
            }
            return View(film_actor);
        }

        // POST: film_actor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("actor_id,film_id,last_update")] film_actor film_actor)
        {
            if (id != film_actor.actor_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film_actor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!film_actorExists(film_actor.actor_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(film_actor);
        }

        // GET: film_actor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_actor = await _context.film_actor
                .FirstOrDefaultAsync(m => m.actor_id == id);
            if (film_actor == null)
            {
                return NotFound();
            }

            return View(film_actor);
        }

        // POST: film_actor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film_actor = await _context.film_actor.FindAsync(id);
            _context.film_actor.Remove(film_actor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool film_actorExists(int id)
        {
            return _context.film_actor.Any(e => e.actor_id == id);
        }
    }
}
