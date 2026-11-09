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
