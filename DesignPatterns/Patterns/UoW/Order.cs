namespace DesignPatterns.Patterns.UoW;

public class Order {
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }
    
    public int PersonId { get; set; }
    public Person Person { get; set; }
}