namespace DesignPatterns.Patterns.Command;

public class Receiver {
    public void DoSomething(string text) {
        Console.WriteLine($"Receiver: Working on ({text}.)");
    }

    public void DoSomethingElse(string text) {
        Console.WriteLine($"Receiver: Also working on ({text}).");
    }
}