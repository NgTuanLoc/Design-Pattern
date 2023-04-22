// The Abstract Factory pattern is a creational pattern that provides an interface for creating related or dependent objects without specifying their concrete classes. It allows you to create families of related objects without having to know their specific implementations.

// In an abstract factory pattern, there are abstract factory classes that define the methods for creating objects. These factory classes do not implement the methods themselves, but instead, they are inherited by concrete factory classes that create objects with specific implementations.

// The abstract factory pattern is useful in situations where a system needs to be independent of how its objects are created or composed. By using this pattern, you can ensure that the objects in your system are created consistently and that the system is flexible and easy to modify.
namespace CreationalPatterns
{
  // Abstract product A
  public interface IButton
  {
    void Paint();
  }

  // Abstract product B
  public interface ICheckbox
  {
    void Paint();
  }

  // Concrete product A1
  public class WindowsButton : IButton
  {
    public void Paint()
    {
      Console.WriteLine("Painting a Windows button.");
    }
  }

  // Concrete product B1
  public class WindowsCheckbox : ICheckbox
  {
    public void Paint()
    {
      Console.WriteLine("Painting a Windows checkbox.");
    }
  }

  // Concrete product A2
  public class MacButton : IButton
  {
    public void Paint()
    {
      Console.WriteLine("Painting a Mac button.");
    }
  }

  // Concrete product B2
  public class MacCheckbox : ICheckbox
  {
    public void Paint()
    {
      Console.WriteLine("Painting a Mac checkbox.");
    }
  }

  // Abstract factory
  public interface IGUIFactory
  {
    IButton CreateButton();
    ICheckbox CreateCheckbox();
  }

  // Concrete factory 1
  public class WindowsGUIFactory : IGUIFactory
  {
    public IButton CreateButton()
    {
      return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
      return new WindowsCheckbox();
    }
  }

  // Concrete factory 2
  public class MacGUIFactory : IGUIFactory
  {
    public IButton CreateButton()
    {
      return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
      return new MacCheckbox();
    }
  }
}
