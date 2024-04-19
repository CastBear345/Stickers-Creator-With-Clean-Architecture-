namespace Domain.Entities;

public class Sticker
{
    public long Id { get; set; }

    public required string Name { get; set; }

    public required string Url { get; set; }
}
