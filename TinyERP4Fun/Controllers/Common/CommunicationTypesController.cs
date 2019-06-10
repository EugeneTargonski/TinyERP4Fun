﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TinyERP4Fun.Data;
using TinyERP4Fun.Models.Common;

namespace TinyERP4Fun.Controllers
{
    [Authorize(Roles = Constants.rolesCommon_User)]
    public class CommunicationTypesController : Controller
    {
        private readonly DefaultContext _context;

        public CommunicationTypesController(DefaultContext context)
        {
            _context = context;
        }

        // GET: CommunicationTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommunicationType.ToListAsync());
        }

        // GET: CommunicationTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communicationType = await _context.CommunicationType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communicationType == null)
            {
                return NotFound();
            }

            return View(communicationType);
        }

        // GET: CommunicationTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommunicationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CommunicationType communicationType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communicationType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(communicationType);
        }

        // GET: CommunicationTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communicationType = await _context.CommunicationType.FindAsync(id);
            if (communicationType == null)
            {
                return NotFound();
            }
            return View(communicationType);
        }

        // POST: CommunicationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] CommunicationType communicationType)
        {
            if (id != communicationType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communicationType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunicationTypeExists(communicationType.Id))
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
            return View(communicationType);
        }

        // GET: CommunicationTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communicationType = await _context.CommunicationType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communicationType == null)
            {
                return NotFound();
            }

            return View(communicationType);
        }

        // POST: CommunicationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var communicationType = await _context.CommunicationType.FindAsync(id);
            _context.CommunicationType.Remove(communicationType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunicationTypeExists(long? id)
        {
            return _context.CommunicationType.Any(e => e.Id == id);
        }
    }
}