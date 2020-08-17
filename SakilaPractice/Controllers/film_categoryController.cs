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
    public class film_categoryController : Controller
    {
        private readonly SakilaPracticeContext _context;

        public film_categoryController(SakilaPracticeContext context)
        {
            _context = context;
        }

        // GET: film_category
        public async Task<IActionResult> Index()
        {
            return View(await _context.film_category.ToListAsync());
        }

        // GET: film_category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_category = await _context.film_category
                .FirstOrDefaultAsync(m => m.film_id == id);
            if (film_category == null)
            {
                return NotFound();
            }

            return View(film_category);
        }

        // GET: film_category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: film_category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("film_id,category_id,last_update")] film_category film_category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film_category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film_category);
        }

        // GET: film_category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_category = await _context.film_category.FindAsync(id);
            if (film_category == null)
            {
                return NotFound();
            }
            return View(film_category);
        }

        // POST: film_category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("film_id,category_id,last_update")] film_category film_category)
        {
            if (id != film_category.film_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film_category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!film_categoryExists(film_category.film_id))
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
            return View(film_category);
        }

        // GET: film_category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film_category = await _context.film_category
                .FirstOrDefaultAsync(m => m.film_id == id);
            if (film_category == null)
            {
                return NotFound();
            }

            return View(film_category);
        }

        // POST: film_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film_category = await _context.film_category.FindAsync(id);
            _context.film_category.Remove(film_category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool film_categoryExists(int id)
        {
            return _context.film_category.Any(e => e.film_id == id);
        }
    }
}
