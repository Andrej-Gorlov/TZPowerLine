using TZPowerLine;

List<Automobile> automobiles = new List<Automobile>()
        {
            new SportCar(5.3, 50, 39, 190),
            new Car(8, 60, 60, 110, 5, 2),
            new Truck(25, 800, 800, 100, 20000, 15000)
        };

foreach (var automobile in automobiles)
{
    automobile.DisplayCurrentFuelRange();
}