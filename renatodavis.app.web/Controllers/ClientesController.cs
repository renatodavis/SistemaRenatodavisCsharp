using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;

namespace renatodavis.app.web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _context;

        public ClientesController(IClienteRepository context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 4;
            int numeroPagina = (pagina ?? 1);
            return View(await _context.GetAll().Result.ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            
            
            var cliente = await _context.GetById(id);
                
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,Nome")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await _context.Add(cliente);                 
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //_context.bExisteCliente(id)
            var cliente = await _context.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,Nome")] Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Update(cliente);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ClienteId))
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {

            var cliente = await _context.GetById(id);
                
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.GetById(id);
            await _context.Remove(cliente);            
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.bExisteCliente(id);            
        }
    }
}
