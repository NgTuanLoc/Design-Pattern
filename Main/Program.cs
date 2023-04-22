
using CreationalPatterns;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    // ========== Singleton Patterns ==========
    Singleton instance = Singleton.Instance;
    instance.SayHello();
    instance.SayHello();
    instance.SayHello();
    instance.SayHello();

    // ========== Factory Patterns ==========
    // Create an instance of CarFactory and drive a car
    VehicleFactory carFactory = new CarFactory();
    IVehicle car = carFactory.CreateVehicle();
    car.Drive();

    // Create an instance of MotorcycleFactory and drive a motorcycle
    VehicleFactory motorcycleFactory = new MotorcycleFactory();
    IVehicle motorcycle = motorcycleFactory.CreateVehicle();
    motorcycle.Drive();

    // ========== Abstract Factory Patterns ==========
    IGUIFactory factory;
    IButton button;
    ICheckbox checkbox;

    // Create a Windows GUI
    factory = new WindowsGUIFactory();
    button = factory.CreateButton();
    checkbox = factory.CreateCheckbox();
    button.Paint();
    checkbox.Paint();

    // Create a Mac GUI
    factory = new MacGUIFactory();
    button = factory.CreateButton();
    checkbox = factory.CreateCheckbox();
    button.Paint();
    checkbox.Paint();
  }
}
