namespace TZPowerLine
{
    internal abstract record Automobile
    {
        public double AverageFuelConsumption { get; protected set; }
        public double FuelTankCapacity { get; protected set; }
        public double CurrentFuel { get; protected set; }
        public double Speed { get; protected set; }
        protected const double km = 100;

        public Automobile(double averageFuelConsumption, double fuelTankCapacity,
            double currentFuel, double speed)
        {
            AverageFuelConsumption = averageFuelConsumption/ km;
            FuelTankCapacity = fuelTankCapacity;
            CurrentFuel = currentFuel;
            Speed = speed;
        }
        public void DisplayCurrentFuelRange()
        {
            Console.WriteLine($"Текущий запас хода равен {CalcFuelRangeOfCurrentFuel()} км");
        }
        public double CalcTimeToCoverDistance(double distance) => distance / Speed;
        public double CalcFuelRangeOfFullFuelTack() => CalcFuelRange(FuelTankCapacity);
        private double CalcFuelRangeOfCurrentFuel() => CalcFuelRange(CurrentFuel);
        protected virtual double CalcFuelRange(double fuel) => fuel / AverageFuelConsumption;
    }
}
