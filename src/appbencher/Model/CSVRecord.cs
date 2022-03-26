namespace appbencher.Model;

public record CSVRecord
{
    public int Id { get; set; }
    public double Value { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Guid TransactionId { get; set; }
    public DateTime TransactionDate { get; set; }
    public string CardType { get; set; }
    public string MerchantCode { get; set; }

}
