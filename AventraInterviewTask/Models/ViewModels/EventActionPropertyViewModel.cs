using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models.ViewModels
{
    public class EventActionPropertyViewModel
    {
        public IEnumerable<EventCategory> EventCategoryList { get; set; }
        public IEnumerable<EventActionItem> EventActionItemList { get; set; }
        public EventActionProperty EventActionProperty { get; set; }
    }
}
