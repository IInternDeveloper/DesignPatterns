using System.Text;

namespace DesignPatterns.Patterns.Composite;

public class Composite : Component {
    private readonly List<Component> _children = [];

    public override void Add(Component component) {
        _children.Add(component);
    }

    public override void Remove(Component component) {
        _children.Remove(component);
    }
    
    public override string Operation() {
        var result = new StringBuilder("Branch(");
        for (int i = 0; i < _children.Count; i++) {
            result.Append(_children[i].Operation());
            if (i != _children.Count - 1) {
                result.Append('+');
            }
        }
        
        return result.Append(')').ToString();
    }
}