namespace HomeApplianceRepairCenter.Models
{
    public class WashingMachine : Appliance
    {
        private double motorCost;

        public WashingMachine(
            string serial,
            string customer,
            double motorCost)
            : base(serial, customer)
        {
            this.motorCost = motorCost;
        }

        public override double CalculateRepairCost()
        {
            return motorCost + 100;
        }
    }
}
