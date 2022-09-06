namespace WinFormsApp1.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CustomerType Type { get; set; }
}