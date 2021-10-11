using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models.ViewModels
{
    public class MennuItemViewModel
    {
        public IEnumerable<EventCategory> EventCategoryList { get; set; }
        public EventActionItem EventActionItem { get; set; }

        public List<string> EventAction { get; set; }

        public BaseClassEventAction BaseClassEventAction { get; set; }
    }
}
