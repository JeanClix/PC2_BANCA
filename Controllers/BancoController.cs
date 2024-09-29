using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC2.Models;
using PC2.Data;
using PC2.ViewModel;

namespace PC2.Controllers
{
    public class BancoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BancoController(ApplicationDbContext context)
        {
            _context = context;
        }

        

        // POST: Banco/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BancoVM viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Bancos.Add(viewModel.FormBanco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            viewModel.ListBanco = await _context.Bancos.ToListAsync();
            return View("Index", viewModel);
        }
    }
}