namespace DesignPatterns.Patterns.Decorator;

public abstract class Decorator : Component {
    protected Component _component;

    public Decorator(Component component) {
        _component = component;
    }

    public void SetComponent(Component component) {
        _component = component;
    }

    public override string Operation() {
        if (_component is not null) {
            return _component.Operation();
        }
        
        return string.Empty;
    }
}