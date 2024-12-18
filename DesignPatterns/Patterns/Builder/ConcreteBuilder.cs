﻿namespace DesignPatterns.Patterns.Builder;

public class ConcreteBuilder : IBuilder {
    private Product _product;

    public ConcreteBuilder() {
        Reset();
    }
    
    public void BuildPartA() {
        _product.Add("PartA1");
    }

    public void BuildPartB() {
        _product.Add("PartB1");
    }

    public void BuildPartC() {
        _product.Add("PartC1");
    }

    public Product GetProduct() {
        var result = _product;
        Reset();

        return result;
    }
    
    private void Reset() {
        _product = new Product();
    }
}
