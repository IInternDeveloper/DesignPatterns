namespace DesignPatterns.Patterns.Observer;

public class ConcreteObserverA : IObserver {
    public void Update(ISubject subject) {
        if (subject is Subject { State: < 3 }) {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}