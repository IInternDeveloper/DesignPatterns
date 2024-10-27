using System.Collections;

namespace DesignPatterns.Patterns.Iterator;

public abstract class Iterator : IEnumerator {
    object IEnumerator.Current => Current();
    
    public abstract object Current();

    public abstract int Key();

    public abstract bool MoveNext();

    public abstract void Reset();
}