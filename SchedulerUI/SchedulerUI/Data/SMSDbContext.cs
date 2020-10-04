using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUI.Data
{
    class SMSDbContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
