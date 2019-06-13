﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models;
using TinyERP4Fun.Models.Common;
using TinyERP4Fun.ModelServiceInterfaces;

namespace TinyERP4Fun.Controllers.Common
{
    [Authorize(Roles = Constants.rolesCommon_User)]
    public class CurrenciesController : Controller
    {
        private readonly DefaultContext _context;
        private readonly IGeneralService _generalService;

        public CurrenciesController(DefaultContext context, IGeneralService generalService)
        {
            _context = context;
            _generalService = generalService;
        }

        // GET: Currencies
        public async Task<IActionResult> Index(int? pageNumber)
        {
            var defaultContext = _context.Currency.OrderBy(x => x.Name);
            return View(await PaginatedList<Currency>.CreateAsync(defaultContext.AsNoTracking(), pageNumber ?? 1, Constants.pageSize));
        }

        // GET: Currencies/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            var result = await _generalService.GetObject<Currency>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // GET: Currencies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Currencies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,Name2,Part001Name,Part001Name2,Active,Base")] Currency currency)
        {
            if (ModelState.IsValid)
            {
                _context.Add(currency);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(currency);
        }

        // GET: Currencies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            var result = await _generalService.GetObject<Currency>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: Currencies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Code,Name,Name2,Part001Name,Part001Name2,Active,Base")] Currency currency)
        {
            if (id != currency.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(currency);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurrencyExists(currency.Id)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(currency);
        }

        // GET: Currencies/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            var result = await _generalService.GetObject<Currency>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: Currencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var currency = await _context.Currency.FindAsync(id);
            _context.Currency.Remove(currency);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurrencyExists(long? id)
        {
            return _context.Currency.Any(e => e.Id == id);
        }
    }
}
