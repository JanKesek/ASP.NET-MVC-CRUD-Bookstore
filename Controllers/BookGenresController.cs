using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookstoreCRUD.Models;

namespace BookstoreCRUD.Controllers
{
    public class BookGenresController : Controller
    {
        private readonly BookstoreContext _context;

        public BookGenresController(BookstoreContext context)
        {
            _context = context;
        }

        // GET: BookGenres
        public async Task<IActionResult> Index()
        {
            var bookstoreContext = _context.BookGenre.Include(b => b.Genre).Include(b => b.IsbnNavigation);
            return View(await bookstoreContext.ToListAsync());
        }

        // GET: BookGenres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGenre = await _context.BookGenre
                .Include(b => b.Genre)
                .Include(b => b.IsbnNavigation)
                .FirstOrDefaultAsync(m => m.GenreId == id);
            if (bookGenre == null)
            {
                return NotFound();
            }

            return View(bookGenre);
        }

        // GET: BookGenres/Create
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId");
            ViewData["Isbn"] = new SelectList(_context.Book, "Isbn", "Title");
            return View();
        }

        // POST: BookGenres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenreId,Isbn")] BookGenre bookGenre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookGenre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId", bookGenre.GenreId);
            ViewData["Isbn"] = new SelectList(_context.Book, "Isbn", "Title", bookGenre.Isbn);
            return View(bookGenre);
        }

        // GET: BookGenres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGenre = await _context.BookGenre.FindAsync(id);
            if (bookGenre == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId", bookGenre.GenreId);
            ViewData["Isbn"] = new SelectList(_context.Book, "Isbn", "Title", bookGenre.Isbn);
            return View(bookGenre);
        }

        // POST: BookGenres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenreId,Isbn")] BookGenre bookGenre)
        {
            if (id != bookGenre.GenreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookGenre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookGenreExists(bookGenre.GenreId))
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
            ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "GenreId", bookGenre.GenreId);
            ViewData["Isbn"] = new SelectList(_context.Book, "Isbn", "Title", bookGenre.Isbn);
            return View(bookGenre);
        }

        // GET: BookGenres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGenre = await _context.BookGenre
                .Include(b => b.Genre)
                .Include(b => b.IsbnNavigation)
                .FirstOrDefaultAsync(m => m.GenreId == id);
            if (bookGenre == null)
            {
                return NotFound();
            }

            return View(bookGenre);
        }

        // POST: BookGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookGenre = await _context.BookGenre.FindAsync(id);
            _context.BookGenre.Remove(bookGenre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookGenreExists(int id)
        {
            return _context.BookGenre.Any(e => e.GenreId == id);
        }
    }
}
