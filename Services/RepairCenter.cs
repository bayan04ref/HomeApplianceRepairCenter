using System.Collections.Generic;
using HomeApplianceRepairCenter.Models;

namespace HomeApplianceRepairCenter.Services
{
    public delegate void StatusChangedHandler(
        Appliance appliance);

    public class RepairCenter
    {
        private List<Appliance> appliances =
            new List<Appliance>();

        public static int RepairedDevicesCount
        {
            get;
            private set;
        }

        public event StatusChangedHandler DeviceRepaired;

        public void AddAppliance(
            Appliance appliance)
        {
            appliances.Add(appliance);
        }

                public void UpdateStatus(
            Appliance appliance,
            DeviceStatus status)
        {
            appliance.Status = status;

            if (status == DeviceStatus.Repaired)
            {
                RepairedDevicesCount++;

                DeviceRepaired?.Invoke(
                    appliance);
            }
        }

        public double GetTotalRepairCost()
        {
            double total = 0;

            foreach (var appliance in appliances)
            {
                total += appliance.CalculateRepairCost();
            }

            return total;
        }

        public void DisplayAllDevices()
        {
            foreach (var appliance in appliances)
            {
                appliance.DisplayInfo();

                Console.WriteLine(
                    $"Repair Cost : {appliance.CalculateRepairCost()}");

                Console.WriteLine(
                    $"Last Note : {appliance.GetLastMaintenanceNote()}");

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
