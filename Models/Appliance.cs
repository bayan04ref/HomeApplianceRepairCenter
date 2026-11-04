using System;
using HomeApplianceRepairCenter.Interfaces;

namespace HomeApplianceRepairCenter.Models
{
    public abstract class Appliance :
        IRepairable,
        IMaintenanceTrackable
    {
        private string serialNumber;
        private string customerName;
        private DeviceStatus status;

        protected RepairRecord repairRecord;

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public DeviceStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        protected Appliance(
            string serialNumber,
            string customerName)
        {
            this.serialNumber = serialNumber;
            this.customerName = customerName;

            status = DeviceStatus.UnderMaintenance;

            repairRecord = new RepairRecord();
        }

        public void AddMaintenanceNote(string note)
        {
            repairRecord.AddNote(note);
        }

        public string GetLastMaintenanceNote()
        {
            return repairRecord.GetLastNote();
        }

        public abstract double CalculateRepairCost();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Serial : {SerialNumber}");
            Console.WriteLine($"Customer : {CustomerName}");
            Console.WriteLine($"Status : {Status}");
        }
    }
}
