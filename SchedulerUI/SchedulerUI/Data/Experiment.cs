using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUI.Data
{
    class Experiment
    {
        [Key]
        public int ExperimentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Participant")]
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
        public ICollection<Participant> Participants { get; set; }
    }
}
