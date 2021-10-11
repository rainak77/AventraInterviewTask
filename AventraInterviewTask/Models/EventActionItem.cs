using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class EventActionItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string EventActionType { get; set; }

        [Display(Name = "EventCategory")]
        public int EventCategoryId { get; set; }

        [ForeignKey("EventCategoryId")]
        public virtual EventCategory EventCategory { get; set; }

    }
}
