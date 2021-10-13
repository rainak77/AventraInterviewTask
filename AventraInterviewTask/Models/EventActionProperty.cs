using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class EventActionProperty:BaseClassEventAction
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "EventCategory")]
        public int EventCategoryId { get; set; }

        [ForeignKey("EventCategoryId")]
        public virtual EventCategory EventCategory { get; set; }


        [Display(Name = "EventActionItem")]
        public int EventActionItemId { get; set; }

        [ForeignKey("EventActionItemId")]
        public virtual EventActionItem EventActionItem { get; set; }
    }
}
