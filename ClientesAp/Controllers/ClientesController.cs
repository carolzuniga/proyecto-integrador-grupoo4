using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClientesAp.Data;
using ClientesAp.
    
    
    Models;

namespace ClientesAp.Controllers
{
    public class ClientesController : Controller
    {
        private readonly AppDbContext _db;
        public ClientesController(AppDbContext db) => _db = db;

        // GET: /Clientes
        public async Task<IActionResult> Index(string? q)
        {
            var query = _db.Clientes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(q))
                query = query.Where(c => EF.Functions.Like(c.Nombre, $"%{q}%") ||
                                         EF.Functions.Like(c.Apellido, $"%{q}%"));
            var list = await query.OrderBy(c => c.Id).ToListAsync();
            return View(list);
        }

        // GET: /Clientes/Create
        public IActionResult Create() => View();

        // POST: /Clientes/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente c)
        {
            if (!ModelState.IsValid) return View(c);
            _db.Add(c);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Clientes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var c = await _db.Clientes.FindAsync(id);
            if (c == null) return NotFound();
            return View(c);
        }

        // POST: /Clientes/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cliente c)
        {
            if (id != c.Id) return BadRequest();
            if (!ModelState.IsValid) return View(c);
            _db.Update(c);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Clientes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var c = await _db.Clientes.FindAsync(id);
            if (c == null) return NotFound();
            return View(c);
        }

        // POST: /Clientes/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var c = await _db.Clientes.FindAsync(id);
            if (c == null) return NotFound();
            _db.Clientes.Remove(c);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Clientes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var c = await _db.Clientes.FindAsync(id);
            return c == null ? NotFound() : View(c);
        }
    }
}