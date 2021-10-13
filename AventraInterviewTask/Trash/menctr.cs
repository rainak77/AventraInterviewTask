//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using AventraInterviewTask.Models;
//using AventraInterviewTask.Models.ViewModels;

//namespace AventraInterviewTask.Controllers
//{
//    public class MenuItemsController : Controller
//    {
//        private readonly EventContext _context;

//        public MenuItemsController(EventContext context)
//        {
//            _context = context;
//        }

//        // GET: MenuItems
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.MenuItem.ToListAsync());
//        }

        
//        // GET: MenuItems/Create
//        public async Task<IActionResult> Create()
//        {
//            MennuItemViewModel model = new MennuItemViewModel()
//            {
//                EventCategoryList= await _context.EventCategory.ToListAsync(),
//                EventActionItem = new Models.EventActionItem(),
//                EventAction = await _context.EventActionItem
//                                            .OrderBy(p => p.EventActionType)
//                                            .Select(p => p.EventActionType)
//                                            .Distinct().ToListAsync(),
//                BaseClassEventAction=new Models.BaseClassEventAction()
//            };
//            return View(model);
//        }

//        // POST: MenuItems/Create
        
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(MennuItemViewModel model)
//        {
           
//            if (ModelState.IsValid)
//            {
//                _context.Add(model);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(model);
//        }
//    }
//}
