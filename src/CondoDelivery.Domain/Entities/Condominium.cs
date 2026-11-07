namespace CondoDelivery.Domain.Entities;

public sealed class Condominium
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public DateTimeOffset CreatedAtUtc { get; private set; }

    public Condominium(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Condominium name is required.",
                nameof(name));
        }

        Id = Guid.NewGuid();
        Name = name.Trim();
        CreatedAtUtc = DateTimeOffset.UtcNow;
    }

    public void Rename(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Condominium name is required.",
                nameof(name));
        }

        Name = name.Trim();
    }
}