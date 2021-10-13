using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AventraInterviewTask.Models
{
    public class EventContext:DbContext
    {
        public EventContext(DbContextOptions<EventContext> options):base(options){ }

        public DbSet<EventCategory> EventCategory { get; set; }
        public DbSet<EventActionItem> EventActionItem { get; set; }
       
        public DbSet<EventActionProperty> EventActionProperty { get; set; }


    }
}
