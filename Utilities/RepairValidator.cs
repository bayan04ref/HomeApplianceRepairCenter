using System;
using System.Text.RegularExpressions;

namespace HomeApplianceRepairCenter.Utilities
{
    public static class RepairValidator
    {
        public static bool IsValidSerial(string serial)
        {
            return Regex.IsMatch(
                serial,
                @"^[A-Z]{3}[0-9]{4}$");
        }

        public static bool IsValidDate(DateTime date)
        {
            return date <= DateTime.Today;
        }
    }
}
