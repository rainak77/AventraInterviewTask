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
    public class EventActionListsController : Controller
    {
        private readonly EventContext _context;

        public EventActionListsController(EventContext context)
        {
            _context = context;
        }

        // GET: EventActionLists
        public async Task<IActionResult> Index()
        {
            var eventContext = await _context.EventActionItem.Include(e => e.EventCategory).ToListAsync();
            return View(eventContext);
        }

        

        // GET: EventActionLists/Create
        public async Task<IActionResult> Create()
        {
            EventAndEvActionViewModel model = new EventAndEvActionViewModel()
            {
                EventCategoryList = await _context.EventCategory.ToListAsync(),
                EventActionItem = new Models.EventActionItem(),
                EventActionItemList = await _context.EventActionItem
                                            .OrderBy(p=>p.EventActionType)
                                            .Select(p=>p.EventActionType)
                                            .Distinct().ToListAsync()
                
            };
            //ViewData["EventCategoryId"] = new SelectList(_context.EventCategory, "Id", "EventType");
            return View(model);
        }



        // GET: EventActionLists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventAndEvActionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesActionExist = _context.EventActionItem
                    .Include(s => s.EventCategory)
                    .Where(s => s.EventActionType == model.EventActionItem.EventActionType && s.EventCategory.Id == model.EventActionItem.EventCategoryId);

                if (doesActionExist.Count() > 0) {
                    //error
                }
                else
                {
                    _context.EventActionItem.Add(model.EventActionItem);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
               
            return View(model);
        }


    }
}
