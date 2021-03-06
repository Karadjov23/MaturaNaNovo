using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class SignalController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        public SignalController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Signal
        public async Task<IActionResult> Index()
        {
            
            var applicationDbContext = _context.Signals.Include(s => s.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Signal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signal = await _context.Signals
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signal == null)
            {
                return NotFound();
            }

            return View(signal);
        }

        // GET: Signal/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Signal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Description,Date")] Signal signal)
        {
            if (ModelState.IsValid)
            {
                signal.UserId = _userManager.GetUserId(User);
                _context.Add(signal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           // ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", signal.UserId);
            return View(signal);
        }

        // GET: Signal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signal = await _context.Signals.FindAsync(id);
            if (signal == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", signal.UserId);
            return View(signal);
        }

        // POST: Signal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Description,Date")] Signal signal)
        {
            if (id != signal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignalExists(signal.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", signal.UserId);
            return View(signal);
        }

        // GET: Signal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signal = await _context.Signals
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signal == null)
            {
                return NotFound();
            }

            return View(signal);
        }

        // POST: Signal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var signal = await _context.Signals.FindAsync(id);
            _context.Signals.Remove(signal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignalExists(int id)
        {
            return _context.Signals.Any(e => e.Id == id);
        }
    }
}