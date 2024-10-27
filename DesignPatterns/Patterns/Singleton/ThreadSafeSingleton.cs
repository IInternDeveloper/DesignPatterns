namespace DesignPatterns.Patterns.Singleton;

public sealed class ThreadSafeSingleton {
    private static ThreadSafeSingleton? _instance;
    private static readonly object _locker = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance() {
        if (_instance is null) {
            lock (_locker) {
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
