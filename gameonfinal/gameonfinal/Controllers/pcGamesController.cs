﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gameonfinal.Models;

namespace gameonfinal.Controllers
{
    public class pcGamesController : Controller
    {
        private readonly gameonContext _context;

        public pcGamesController(gameonContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var gameonContext = _context.Games.Include(g => g.Gametype).Include(g => g.PlatForm);
            return View(await gameonContext.ToListAsync());
        }

        // GET: Games/Details/5
        [Route("pcGames/{plat}")]
        public  ActionResult Details(string plat)
        {
            if (plat == null)
            {
                return NotFound();
            }
            var platforms = from p in _context.Games
                            select p;
            if (!string.IsNullOrEmpty(plat))
            {
                platforms = platforms.Where(p => p.PlatForm.Title.Contains("Playsation"));
            }
           

            return View();
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            ViewData["GametypeId"] = new SelectList(_context.GameType, "GametypeId", "GameType1");
            ViewData["PlatFormId"] = new SelectList(_context.Platforms, "PlatformId", "Title");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Releasedate,PlatFormId,GametypeId,PhotoCover")] Games games)
        {
            if (ModelState.IsValid)
            {
                _context.Add(games);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GametypeId"] = new SelectList(_context.GameType, "GametypeId", "GameType1", games.GametypeId);
            ViewData["PlatFormId"] = new SelectList(_context.Platforms, "PlatformId", "Title", games.PlatFormId);
            return View(games);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var games = await _context.Games.FindAsync(id);
            if (games == null)
            {
                return NotFound();
            }
            ViewData["GametypeId"] = new SelectList(_context.GameType, "GametypeId", "GameType1", games.GametypeId);
            ViewData["PlatFormId"] = new SelectList(_context.Platforms, "PlatformId", "Title", games.PlatFormId);
            return View(games);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Releasedate,PlatFormId,GametypeId,PhotoCover")] Games games)
        {
            if (id != games.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(games);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GamesExists(games.Id))
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
            ViewData["GametypeId"] = new SelectList(_context.GameType, "GametypeId", "GameType1", games.GametypeId);
            ViewData["PlatFormId"] = new SelectList(_context.Platforms, "PlatformId", "Title", games.PlatFormId);
            return View(games);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var games = await _context.Games
                .Include(g => g.Gametype)
                .Include(g => g.PlatForm)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (games == null)
            {
                return NotFound();
            }

            return View(games);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var games = await _context.Games.FindAsync(id);
            _context.Games.Remove(games);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GamesExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }
}
