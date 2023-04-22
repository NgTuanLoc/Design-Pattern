
using CreationalPatterns;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Singleton.Log();

    // ========== Factory Patterns ==========
    // Create an instance of CarFactory and drive a car
    VehicleFactory carFactory = new CarFactory();
    IVehicle car = carFactory.CreateVehicle();
    car.Drive();

    // Create an instance of MotorcycleFactory and drive a motorcycle
    VehicleFactory motorcycleFactory = new MotorcycleFactory();
    IVehicle motorcycle = motorcycleFactory.CreateVehicle();
    motorcycle.Drive();
  }
}
