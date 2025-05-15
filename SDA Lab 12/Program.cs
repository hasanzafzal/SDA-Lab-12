using System;
using DesignPatternsLab13;

class Program
{
    static void Main(string[] args)
    {
        // Strategy Pattern Demo
        Console.WriteLine("=== STRATEGY PATTERN ===");
        var context = new Context();
        context.SetStrategy(new ConcreteStrategyA());
        context.DoSomeBusinessLogic();

        context.SetStrategy(new ConcreteStrategyB());
        context.DoSomeBusinessLogic();

        // Adapter Pattern Demo
        Console.WriteLine("\n=== ADAPTER PATTERN ===");
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        Console.WriteLine(target.GetRequest());
    }
}
