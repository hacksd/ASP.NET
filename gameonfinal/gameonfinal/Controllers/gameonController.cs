using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using gameonfinal.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace gameonfinal.Controllers
{
    public class gameonController : Controller
    {
        private readonly gameonContext _context;
        private UserManager<IdentityUser> _userManager;
        private IHostingEnvironment _webroot;

        public gameonController(gameonContext context, UserManager<IdentityUser> userManager, IHostingEnvironment webroot)
        {
            _context = context;
            _userManager = userManager;
            _webroot = webroot;
        }

        // GET: users
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: users
        [Authorize]
        public async Task<IActionResult> Browse()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: users/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datingProfile = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datingProfile == null)
            {
                return NotFound();
            }

            return View(datingProfile);
        }

        [Authorize]
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datingProfile = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datingProfile == null)
            {
                return NotFound();
            }

            return View(datingProfile);
        }

        // GET: DatingProfiles/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        public IActionResult ProfileInfo()
        {
            string userID = _userManager.GetUserId(User);
  //if error is here
            Users profile = _context.Users.FirstOrDefault(p => p.UserAccountId == userID);

            if (profile == null)
            {
                return RedirectToAction("Create");

            }


            return View(profile);

        }

        // POST: users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Dateaccountcreated, DisplayName,UserAccountId")] Users userprofile,
            IFormFile FilePhoto)
        {

            if (FilePhoto.Length > 0)
            {

                string photoPath = _webroot.WebRootPath + "\\userPhotos\\";
                var fileName = Path.GetFileName(FilePhoto.FileName);

                using (var stream = System.IO.File.Create(photoPath + fileName))
                {
                    await FilePhoto.CopyToAsync(stream);
                    userprofile.PhotoPath = fileName;
                }
            }



            if (ModelState.IsValid)
            {
                _context.Add(userprofile);
                await _context.SaveChangesAsync();
                return RedirectToAction("ProfileInfo");
            }
            return View(userprofile);
        }

        // GET: DatingProfiles/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userprofile = await _context.Users.FindAsync(id);
            if (userprofile == null)
            {
                return NotFound();
            }
            return View(userprofile);
        }

        // POST: userprofile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Dateaccountcreated, DisplayName,UserAccountId")] Users userProfile)
        {
            if (id != userProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatingProfileExists(userProfile.Id))
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
            return View(userProfile);
        }

        // GET: DatingProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfile = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userProfile == null)
            {
                return NotFound();
            }

            return View(userProfile);
        }

        // POST: DatingProfiles/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userProfile = await _context.Users.FindAsync(id);
            _context.Users.Remove(userProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatingProfileExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
