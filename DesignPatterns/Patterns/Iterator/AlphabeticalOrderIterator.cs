﻿using System.Collections;

namespace DesignPatterns.Patterns.Iterator;

public class AlphabeticalOrderIterator : Iterator {
    private readonly WordsCollection _collection;
    
    private readonly bool _reverse;
    private int _position = -1;

    public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false) {
        _collection = collection;
        _reverse = reverse;

        if (reverse) {
            _position = _collection.GetItems().Count;
        }
    }

    public override object Current() {
        return _collection.GetItems()[_position];
    }

    public override int Key() => _position;

    public override bool MoveNext() {
        int updatedPosition = _position + (_reverse ? -1 : 1);

        if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count) {
            _position = updatedPosition;
            
            return true;
        }

        return false;
    }

    public override void Reset() {
        _position = _reverse ? _collection.GetItems().Count - 1 : 0;
    }
}