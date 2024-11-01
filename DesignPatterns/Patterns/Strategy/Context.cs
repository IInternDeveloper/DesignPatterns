namespace DesignPatterns.Patterns.Strategy;

public class Context {
    private IStrategy _strategy;

    public Context() {
        
    }

    public Context(IStrategy strategy) {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy) {
        _strategy = strategy;
    }

    public void DoSomeBusinessLogic() {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
        var list = new List<string>() { "a", "b", "c", "d", "e" };
        
        var result = _strategy.DoAlgorithm(list) as List<string>;
        var concatenatedResult = string.Join(",", result);
        
        Console.WriteLine(concatenatedResult);
    }
}