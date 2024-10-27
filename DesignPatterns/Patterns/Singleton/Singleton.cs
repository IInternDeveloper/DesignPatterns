namespace DesignPatterns.Patterns.Singleton;

public sealed class Singleton {
    private static Singleton? _instance;

    private Singleton() { }

    public static Singleton GetInstance() {
        if (_instance is null) {
            _instance = new Singleton();
        }

        return _instance;
    }

    public void SomeBusinessLogic() {
        // ...
    }
}