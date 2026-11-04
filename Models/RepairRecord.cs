using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeApplianceRepairCenter.Models
{
    public class RepairRecord
    {
        private List<string> maintenanceNotes;

        public DateTime CreatedDate { get; }

        public RepairRecord()
        {
            CreatedDate = DateTime.Now;
            maintenanceNotes = new List<string>();
        }

        public void AddNote(string note)
        {
            if (!string.IsNullOrWhiteSpace(note))
            {
                maintenanceNotes.Add(note);
            }
        }

        public string GetLastNote()
        {
            if (maintenanceNotes.Count == 0)
                return "No maintenance notes";

            return maintenanceNotes.Last();
        }
    }
}
