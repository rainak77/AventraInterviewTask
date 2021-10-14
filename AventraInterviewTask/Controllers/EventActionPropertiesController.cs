using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AventraInterviewTask.Models;
using AventraInterviewTask.Models.ViewModels;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

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
                var data=model.EventActionProperty;
                data.EventActionType = await (from item in _context.EventActionItem where item.Id == data.EventActionItemId select item.EventActionType).FirstOrDefaultAsync();
                data.EventType = await (from item in _context.EventCategory where item.Id == data.EventCategoryId select item.EventType).FirstOrDefaultAsync();

                EventActionProperty xmlmodel = new EventActionProperty()
                {
                    EventActionItem = data.EventActionItem,
                    EventCategory = data.EventCategory,
                    ExpectedHttpStatus = data.ExpectedHttpStatus,
                    SupportEmail= data.SupportEmail,
                    SupportEmailCC= data.SupportEmailCC,
                    MailTemplate= data.MailTemplate,
                    MaxRecordsPerFile= data.MaxRecordsPerFile,
                    HttpMethod= data.HttpMethod,
                    Password= data.Password,
                    Username= data.Username,
                    Comment= data.Comment,
                    Validate= data.Validate,
                    DataType= data.DataType
                };


                XmlSerializer xsSubmit = new XmlSerializer(typeof(EventActionProperty));
                var xml ="";
                using (var sww = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sww))
                    {
                        xsSubmit.Serialize(writer, xmlmodel);
                        xml = sww.ToString(); //  XML data
                    }
                }
                _context.EventActionProperty.Add(model.EventActionProperty);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        

        
    }
}
