using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using midterm.Data;
using midterm.Models;

namespace midterm.Controllers
{
    public class AbilitiesController : Controller
    {
        private readonly Context _context;

        public AbilitiesController(Context context)
        {
            _context = context;
        }

        // GET: Abilities
        public async Task<IActionResult> Index()
        {
            var context = _context.Abilities.Include(a => a.course).Include(a => a.teacher);
            return View(await context.ToListAsync());
        }

        // GET: Abilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Abilities
                .Include(a => a.course)
                .Include(a => a.teacher)
                .FirstOrDefaultAsync(m => m.AbilityID == id);
            if (ability == null)
            {
                return NotFound();
            }

            return View(ability);
        }

        // GET: Abilities/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID");
            ViewData["TeacherID"] = new SelectList(_context.Teachers, "TeacherID", "TeacherID");
            return View();
        }

        // POST: Abilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AbilityID,CourseID,TeacherID")] Ability ability)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", ability.CourseID);
            ViewData["TeacherID"] = new SelectList(_context.Teachers, "TeacherID", "TeacherID", ability.TeacherID);
            return View(ability);
        }

        // GET: Abilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Abilities.FindAsync(id);
            if (ability == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", ability.CourseID);
            ViewData["TeacherID"] = new SelectList(_context.Teachers, "TeacherID", "TeacherID", ability.TeacherID);
            return View(ability);
        }

        // POST: Abilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AbilityID,CourseID,TeacherID")] Ability ability)
        {
            if (id != ability.AbilityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbilityExists(ability.AbilityID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseID", ability.CourseID);
            ViewData["TeacherID"] = new SelectList(_context.Teachers, "TeacherID", "TeacherID", ability.TeacherID);
            return View(ability);
        }

        // GET: Abilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Abilities
                .Include(a => a.course)
                .Include(a => a.teacher)
                .FirstOrDefaultAsync(m => m.AbilityID == id);
            if (ability == null)
            {
                return NotFound();
            }

            return View(ability);
        }

        // POST: Abilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ability = await _context.Abilities.FindAsync(id);
            _context.Abilities.Remove(ability);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbilityExists(int id)
        {
            return _context.Abilities.Any(e => e.AbilityID == id);
        }
    }
}
