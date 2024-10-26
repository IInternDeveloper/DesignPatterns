namespace DesignPatterns.Patterns.Singleton;

public sealed class ThreadSafeSingleton {
    private static ThreadSafeSingleton _instance;
    private static readonly object _lock = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance() {
        if (_instance is null) {
            lock (_lock) {
                if (_instance is null) {
                    _instance = new ThreadSafeSingleton();
                }
            }
        }

        return _instance;
    }

    public void SomeBusinessLogic() {
        // ...
    }
}
