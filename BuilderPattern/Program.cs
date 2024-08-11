namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern");

            GetVehicleInfo(new CarBuilder());

            GetVehicleInfo(new BikeBuilder());

            Console.ReadKey();
        }

        static void GetVehicleInfo(IVehicleBuilder vehicleBuilder)
        {
            Console.WriteLine($"{typeof(IVehicleBuilder)}");
            VehicleDirector vehicleDirector = new VehicleDirector(vehicleBuilder);
            vehicleDirector.BuildVehicle();
            var vehicle = vehicleDirector.GetVehicle();
            PrintVehicleDetails(vehicle);
        }

        static void PrintVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Model: {0}, Speed Limit: {1}, HP: {2}, Cruise Control: {3}, Seats: {4}",
                vehicle.Model,
                vehicle.MaxSpeed,
                vehicle.HorsePower,
                vehicle.HasCruiseControl,
                vehicle.Seats
                );
        }
    }
}