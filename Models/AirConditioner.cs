namespace HomeApplianceRepairCenter.Models
{
    public class AirConditioner : Appliance
    {
        private double compressorCost;

        public AirConditioner(
            string serial,
            string customer,
            double compressorCost)
            : base(serial, customer)
        {
            this.compressorCost = compressorCost;
        }

        public override double CalculateRepairCost()
        {
            return compressorCost + 200;
        }
    }
}
