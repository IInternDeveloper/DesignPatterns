namespace DesignPatterns.Patterns.AbstractFactory;

public interface IAbstractFactory {
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}