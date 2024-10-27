using System.Collections;

namespace DesignPatterns.Patterns.Iterator;

public abstract class IteratorAggregate : IEnumerable {
    public abstract IEnumerator GetEnumerator();
}
