namespace PayMesh.Payment.Api.Entities;

public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
}