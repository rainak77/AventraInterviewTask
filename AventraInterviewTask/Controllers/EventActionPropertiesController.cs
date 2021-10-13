using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AventraInterviewTask.Models;
using AventraInterviewTask.Models.ViewModels;

namespace AventraInterviewTask.Controllers
{
    public class EventActionPropertiesController : Controller
    {
        private readonly EventContext _context;

        public EventActionPropertiesController(EventContext context)
        {
            _context = context;
        }

        // GET: EventActionProperties
        public async Task<IActionResult> Index()
        {
            var eventContext = _context.EventActionProperty.Include(e => e.EventActionItem).Include(e => e.EventCategory);
            return View(await eventContext.ToListAsync());
        }



        // GET: EventActionProperties/Create
        public async Task<IActionResult> Create()
        {
            EventActionPropertyViewModel model = new EventActionPropertyViewModel()
            {
                EventCategoryList = await _context.EventCategory.ToListAsync(),
                EventActionItemList = await _context.EventActionItem.ToListAsync(),
                EventActionProperty=new Models.EventActionProperty()

            };
            return View(model);
        }

        // POST: EventActionProperties/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventActionPropertyViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.EventActionProperty.EventActionItemId = 2;
                _context.EventActionProperty.Add(model.EventActionProperty);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }

        

        
    }
}
