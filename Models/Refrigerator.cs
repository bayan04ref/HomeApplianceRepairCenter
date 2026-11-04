namespace HomeApplianceRepairCenter.Models
{
    public class Refrigerator : Appliance
    {
        private double gasCost;

        public Refrigerator(
            string serial,
            string customer,
            double gasCost)
            : base(serial, customer)
        {
            this.gasCost = gasCost;
        }

        public override double CalculateRepairCost()
        {
            return gasCost + 150;
        }
    }
}
