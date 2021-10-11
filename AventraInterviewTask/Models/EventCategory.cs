using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class EventCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        public string EventType { get; set; }

        public string EventName { get; set; }
    }
}
