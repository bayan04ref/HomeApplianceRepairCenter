using System;
using HomeApplianceRepairCenter.Models;
using HomeApplianceRepairCenter.Services;

namespace HomeApplianceRepairCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepairCenter center =
                new RepairCenter();

            center.DeviceRepaired +=
                appliance =>
                {
                    Console.WriteLine(
                        $"Repair completed for device: {appliance.SerialNumber}");
                };

            Appliance fridge =
                new Refrigerator(
                    "REF1234",
                    "Ahmad",
                    300);

            fridge.AddMaintenanceNote(
                "Gas leakage repaired");

            Appliance washing =
                new WashingMachine(
                    "WAS5678",
                    "Sara",
                    250);

            washing.AddMaintenanceNote(
                "Motor replaced");

            Appliance air =
                new AirConditioner(
                    "AIR9999",
                    "Lina",
                    500);

            air.AddMaintenanceNote(
                "Compressor fixed");

            center.AddAppliance(fridge);
            center.AddAppliance(washing);
            center.AddAppliance(air);

            center.UpdateStatus(
                fridge,
                DeviceStatus.Repaired);

            center.DisplayAllDevices();

            Console.WriteLine(
                $"Total Repair Cost = {center.GetTotalRepairCost()}");

            Console.WriteLine(
                $"Repaired Devices = {RepairCenter.RepairedDevicesCount}");

            Console.ReadKey();
        }
    }
}
