using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTopDesk.Model
{
    public class Incident
    {
        public DateTime dateTimeReported { get; set; }
        public string subject { get; set; }
        public IncidentType type { get; set; }
        public string reportedBy { get; set; }
        public Priority priority { get; set; }
        public Deadline deadline { get; set; }
        public string description { get; set; }
    }

}
