﻿namespace DesignPatterns.Patterns.Strategy;

public class ConcreteStrategyA : IStrategy {
    public object? DoAlgorithm(object data) {
        var list = data as List<string>;
        list?.Sort();

        return list;
    }
}