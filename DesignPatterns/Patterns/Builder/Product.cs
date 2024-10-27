namespace DesignPatterns.Patterns.Builder;

public class Product {
    private readonly List<string> _parts = [];

    public void Add(string part) {
        _parts.Add(part);
    }

    public string ListParts() {
        string result = string.Join(", ", _parts);

        return "Product parts: " + result + "\n";
    }
}