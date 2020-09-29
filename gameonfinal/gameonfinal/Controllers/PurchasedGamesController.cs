using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gameonfinal.Models;

namespace gameonfinal.Controllers
{
    public class PurchasedGamesController : Controller
    {
        private readonly gameonContext _context;

        public PurchasedGamesController(gameonContext context)
        {
            _context = context;
        }

        // GET: PurchasedGames
        public async Task<IActionResult> Index()
        {
            var gameonContext = _context.PurchasedGames.Include(p => p.Game).Include(p => p.User);
            return View(await gameonContext.ToListAsync());
        }

        // GET: PurchasedGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedGames = await _context.PurchasedGames
                .Include(p => p.Game)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchasedGames == null)
            {
                return NotFound();
            }

            return View(purchasedGames);
        }

        // GET: PurchasedGames/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Description");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Displayname");
            return View();
        }

        // POST: PurchasedGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,GameId,DatePurchased")] PurchasedGames purchasedGames)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchasedGames);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Description", purchasedGames.GameId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Displayname", purchasedGames.UserId);
            return View(purchasedGames);
        }

        // GET: PurchasedGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedGames = await _context.PurchasedGames.FindAsync(id);
            if (purchasedGames == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Description", purchasedGames.GameId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Displayname", purchasedGames.UserId);
            return View(purchasedGames);
        }

        // POST: PurchasedGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,GameId,DatePurchased")] PurchasedGames purchasedGames)
        {
            if (id != purchasedGames.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchasedGames);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasedGamesExists(purchasedGames.Id))
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
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Description", purchasedGames.GameId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Displayname", purchasedGames.UserId);
            return View(purchasedGames);
        }

        // GET: PurchasedGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedGames = await _context.PurchasedGames
                .Include(p => p.Game)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchasedGames == null)
            {
                return NotFound();
            }

            return View(purchasedGames);
        }

        // POST: PurchasedGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchasedGames = await _context.PurchasedGames.FindAsync(id);
            _context.PurchasedGames.Remove(purchasedGames);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasedGamesExists(int id)
        {
            return _context.PurchasedGames.Any(e => e.Id == id);
        }
    }
}
