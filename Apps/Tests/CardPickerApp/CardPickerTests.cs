
using CardPickerApp;

namespace Tests.CardPickerApp;

public class CardPickerTests
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
    public void ShouldReturnCorrectNumberOfCards(int count)
    {
        // Assert + Act
        Card[] cards = CardPicker.GetCards(count);

        // Arrange
        Assert.Equal(count, cards.Length);
    }

    [Fact]
    public void ShouldReturnAllCardsWhenCountExceedsTotal()
    {
        // Arrange
        const int expected = 52;
        const int count = 100;

        // Act
        Card[] cards = CardPicker.GetCards(count);

        // Assert
        Assert.Equal(expected, cards.Length);
    }

    [Fact]
    public void ShouldReturnAllCardsWhenCountIsZero()
    {
        // Arrange
        const int expected = 52;
        const int count = 0;

        // Act
        Card[] cards = CardPicker.GetCards(count);

        // Assert
        Assert.Equal(expected, cards.Length);
    }

    [Fact]
    public void ShouldReturnDistinctCardsOnly()
    {
        // Arrange
        const int count = 5;

        // Act
        Card[] cards = CardPicker.GetCards(count);

        // Assert
        Assert.Distinct(cards);
    }
}
