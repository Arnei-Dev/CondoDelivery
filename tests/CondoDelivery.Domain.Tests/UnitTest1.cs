using CondoDelivery.Domain.Entities;
using Xunit;

namespace CondoDelivery.Domain.Tests;

public class CondominiumTests
{
    [Fact]
    public void Constructor_ShouldTrimName()
    {
        var condominium = new Condominium("  Green Gardens  ");

        Assert.Equal("Green Gardens", condominium.Name);
    }

    [Fact]
    public void Constructor_ShouldRejectBlankName()
    {
        Assert.Throws<ArgumentException>(
            () => new Condominium("   "));
    }

    [Fact]
    public void Rename_ShouldUpdateNameAndTrimWhitespace()
    {
        var condominium = new Condominium("Green Gardens");

        condominium.Rename("  Blue Gardens  ");

        Assert.Equal("Blue Gardens", condominium.Name);
    }
}