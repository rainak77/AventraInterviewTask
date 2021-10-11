using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class MenuItem:BaseClassEventAction
    {
        [Key]
        public int Id { get; set; }
        public string EventType { get; set; }
        public string EventActionType { get; set; }



    }
}
