using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUI.Data
{
    class Schedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed), Required]
        public int ScheduleId { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public int Period { get; set; }
        public int Jitter { get; set; }
        public int Reps { get; set; }
    }
}
