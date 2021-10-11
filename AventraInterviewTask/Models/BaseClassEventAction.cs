using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class BaseClassEventAction
    {
        [EmailAddress]
        public string SupportEmail { get; set; }

        [EmailAddress]
        public string SupportEmailCC { get; set; }

        public int MailTemplate { get; set; }

        public bool Validate { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string HttpMethod { get; set; }
        public string ExpectedHttpStatus { get; set; }
        public string DataType { get; set; }
        public string Comment { get; set; }
        public int MaxRecordsPerFile { get; set; }

    }
}
