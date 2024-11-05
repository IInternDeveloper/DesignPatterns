namespace DesignPatterns.Patterns.Observer;

public class ConcreteObserverB : IObserver {
    public void Update(ISubject subject) {
        if (subject is Subject { State: >= 2 }) {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}