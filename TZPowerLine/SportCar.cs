namespace TZPowerLine
{
    internal record SportCar : Automobile
    {
        public SportCar(double averageFuelConsumption, double fuelTankCapacity, double currentFuel, double speed)
        : base(averageFuelConsumption, fuelTankCapacity, currentFuel, speed)
        {
        }
    }
}
