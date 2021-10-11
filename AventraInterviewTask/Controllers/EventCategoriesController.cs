using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AventraInterviewTask.Models;

namespace AventraInterviewTask.Controllers
{
    public class EventCategoriesController : Controller
    {
        private readonly EventContext _context;

        public EventCategoriesController(EventContext context)
        {
            _context = context;
        }

        // GET: EventCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventCategory.ToListAsync());
        }

        
        // GET: EventCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventCategories/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventType,EventName")] EventCategory eventCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventCategory);
        }
       

        
    }
}
