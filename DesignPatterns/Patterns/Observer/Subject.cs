namespace DesignPatterns.Patterns.Observer;

public class Subject : ISubject {
    private readonly List<IObserver> _observers = [];

    public int State { get; private set; }
    
    public void Attach(IObserver observer) {
        _observers.Add(observer);
        Console.WriteLine("Subject: Attached an observer.");
    }

    public void Detach(IObserver observer) {
        _observers.Remove(observer);
        Console.WriteLine("Subject: Detached an observer.");
    }

    public void Notify() {
        Console.WriteLine("Subject: Notifying observers...");
        foreach (var observer in _observers) {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic() {
        Console.WriteLine("\nSubject: I'm doing something important.");
        State = new Random().Next(0, 10);
        
        Thread.Sleep(1000);

        Console.WriteLine($"Subject: My state has just changed to: {State}");
        Notify();
    }
}