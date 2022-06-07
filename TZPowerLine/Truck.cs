namespace TZPowerLine
{
    internal record Truck: Automobile
    {
        private double CarryingCapacity;
        private double CurrentLoad;
        private new double AverageFuelConsumption;

        private const double fuelRangeDecreaseForNKg = 0.04;
        private const double n = 200;

        public Truck(double averageFuelConsumption, double fuelTankCapacity, double currentFuel, double speed,
            double carryingCapacity, double currentLoad)
            : base(averageFuelConsumption, fuelTankCapacity, currentFuel, speed)
        {
            CarryingCapacity = carryingCapacity;
            CurrentLoad = currentLoad;
            AverageFuelConsumption = averageFuelConsumption;
            if (CurrentLoad > CarryingCapacity)
            {
                throw new ArgumentException($"Загруженность не может быть больше {CarryingCapacity}");
            }
        }

        protected override double CalcFuelRange(double fuel)
        {
            double maxDistance = FuelTankCapacity / this.AverageFuelConsumption * km;
            double totalStroke = 0;
            for (int i = 0; i < CurrentLoad/n; i++)
            {
                double powerReserveReduction = fuelRangeDecreaseForNKg * maxDistance ;
                maxDistance -= powerReserveReduction;
                totalStroke += powerReserveReduction;
            }
            return base.CalcFuelRange(fuel) - totalStroke;
        }
    }
}
