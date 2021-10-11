using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class DatabaseEvent: MonitorEventBaseClass
    {
        [Key]
        public int Id { get; set; }
        public string QueryString { get; set; }
        public string UpdateCommand { get; set; }
    }
}
