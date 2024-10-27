namespace DesignPatterns.Patterns.AbstractFactory;

public interface IAbstractProductB {
    string UsefulFunctionB();

    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}