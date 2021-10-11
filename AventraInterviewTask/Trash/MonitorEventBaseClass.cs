using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class MonitorEventBaseClass
    {

        [Required(ErrorMessage = "Required")]
        public string Type { get; set; }

        public string Name { get; set; }
        //public string DelayStartSeconds { get; set; }
    }
}
