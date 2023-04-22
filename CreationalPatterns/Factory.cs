// Factory Method Pattern - defines an interface for creating objects, but allows subclasses to decide which class to instantiate.

// Benefits:
// - It promotes loose coupling between classes, which means that the classes are not tightly bound to one another. This makes the code more flexible and easier to maintain, since changes made to one class do not necessarily affect other classes that depend on it.
// - Easier to extend the system by adding new products without changing the existing code. Instead, new concrete factories can be added to the system to produce the new products. This makes the system more scalable and adaptable to changing requirements.
// -  simplify complex code by separating the product creation logic from the rest of the application logic. This can improve the readability and maintainability of the code, since it is easier to understand and modify smaller, more focused pieces of code.

namespace CreationalPatterns
{
  // Product interface
  public interface IVehicle
  {
    void Drive();
  }

  // Concrete Product
  public class Car : IVehicle
  {
    public void Drive()
    {
      Console.WriteLine("Driving a car");
    }
  }

  public class Motorcycle : IVehicle
  {
    public void Drive()
    {
      Console.WriteLine("Driving a motorcycle");
    }
  }

  // Creator abstract class with factory method
  public abstract class VehicleFactory
  {
    public abstract IVehicle CreateVehicle();
  }

  // Concrete Creator
  public class CarFactory : VehicleFactory
  {
    public override IVehicle CreateVehicle()
    {
      return new Car();
    }
  }

  public class MotorcycleFactory : VehicleFactory
  {
    public override IVehicle CreateVehicle()
    {
      return new Motorcycle();
    }
  }
}