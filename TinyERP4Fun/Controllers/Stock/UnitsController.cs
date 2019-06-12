﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models.Stock;
using TinyERP4Fun.ModelServiceInterfaces;

namespace TinyERP4Fun.Controllers
{
    public class UnitsController : Controller
    {
        private readonly DefaultContext _context;
        private readonly IStockService _stockService;

        public UnitsController(DefaultContext context, IStockService stockService)
        {
            _context = context;
            _stockService = stockService;
        }

        // GET: Units
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unit.ToListAsync());
        }

        // GET: Units/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            var result = await _stockService.GetObject<Unit>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // GET: Units/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Units/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")]Unit unit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unit);
        }

        // GET: Units/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            var result = await _stockService.GetObject<Unit>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: Units/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] Unit unit)
        {
            if (id != unit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnitExists(unit.Id))
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
            return View(unit);
        }

        // GET: Units/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            var result = await _stockService.GetObject<Unit>(id);
            if (result == null) return NotFound();
            return View(result);
        }

        // POST: Units/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var unit = await _context.Unit.FindAsync(id);
            _context.Unit.Remove(unit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnitExists(long id)
        {
            return _context.Unit.Any(e => e.Id == id);
        }
    }
}
