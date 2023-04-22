
using CreationalPatterns;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Singleton instance = Singleton.Instance;
    instance.SayHello();
    instance.SayHello();
    instance.SayHello();
    instance.SayHello();
  }
}
