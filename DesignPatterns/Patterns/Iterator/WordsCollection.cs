using System.Collections;

namespace DesignPatterns.Patterns.Iterator;

public class WordsCollection : IteratorAggregate {
    private readonly List<string> _collection = [];
    private bool _direction = false;

    public void ReverseDirection() {
        _direction = !_direction;
    }

    public List<string> GetItems() => _collection;

    public void AddItem(string item) {
        _collection.Add(item);
    }

    public override IEnumerator GetEnumerator() {
        return new AlphabeticalOrderIterator(this, _direction);
    }
}
