﻿namespace DesignPatterns.Patterns.Decorator;

public class ConcreteDecoratorB : Decorator {
    public ConcreteDecoratorB(Component component) : base(component) {
        
    }

    public override string Operation() {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}