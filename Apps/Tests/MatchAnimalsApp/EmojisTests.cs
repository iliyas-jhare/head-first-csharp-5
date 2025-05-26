using MatchAnimals;

namespace Tests.MatchAnimalsApp;

public class EmojisTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    public void ShouldReturnCorrectNumberOfEmojis(int count)
    {
        // Assert + Act
        Emoji[] emojis = Emojis.GetAnimalEmojis(count);

        // Arrange
        Assert.Equal(count, emojis.Length);
    }

    [Fact]
    public void ShouldReturnAllEmojisWhenCountExceedsTotal()
    {
        // Arrange
        const int expected = 54;
        const int count = 1000;

        // Act
        Emoji[] emojis = Emojis.GetAnimalEmojis(count);

        // Assert
        Assert.Equal(expected, emojis.Length);
    }

    [Fact]
    public void ShouldReturnAllEmojisWhenCountCountIsZero()
    {
        // Arrange
        const int expected = 54;
        const int count = 0;

        // Act
        Emoji[] emojis = Emojis.GetAnimalEmojis(count);

        // Assert
        Assert.Equal(expected, emojis.Length);
    }

    [Fact]
    public void ShouldReturnDistinctEmojis()
    {
        // Arrange
        const int count = 5;

        // Act
        Emoji[] emojis = Emojis.GetAnimalEmojis(count);

        // Assert
        Assert.Distinct(emojis);
    }
}
