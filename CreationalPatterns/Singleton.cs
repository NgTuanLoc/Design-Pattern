// Singleton Pattern: This pattern ensures that only one instance of a class is created and provides a global point of access to that instance.
namespace CreationalPatterns
{
  public class Singleton
  {
    private static readonly Singleton instance = new Singleton();
    private int callCount = 0;
    public Singleton()
    {
    }
    public static Singleton Instance
    {
      get
      {
        return instance;
      }
    }
    public void SayHello()
    {
      Console.WriteLine($"Hello {callCount}");
      callCount++;
    }
    public int getCount()
    {
      return callCount;
    }
  }
}