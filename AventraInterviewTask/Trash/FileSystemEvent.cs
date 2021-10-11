using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class FileSystemEvent: MonitorEventBaseClass
    {
        [Key]
        public int Id { get; set; }
        public string Folder { get; set; }
        public string Filter { get; set; }

    }
}
