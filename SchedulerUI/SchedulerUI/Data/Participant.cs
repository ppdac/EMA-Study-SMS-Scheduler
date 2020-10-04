using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUI.Data
{
    class Participant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public virtual int ParticipantId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string ExternalDataReference { get; set; }
        [Required]
        public string Url1 { get; set; }
        public string Url2 { get; set; }

        public ICollection<Experiment> Experiments { get; set; }
    }
}
