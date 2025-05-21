namespace CardPicker;

public class CardPicker
{
    private static Card[] Cards =>
    [
        // Clubs
        new("2", "Clubs", "♣"),
        new("3", "Clubs", "♣"),
        new("4", "Clubs", "♣"),
        new("5", "Clubs", "♣"),
        new("6", "Clubs", "♣"),
        new("7", "Clubs", "♣"),
        new("8", "Clubs", "♣"),
        new("9", "Clubs", "♣"),
        new("10", "Clubs", "♣"),
        new("J", "Clubs", "♣"),
        new("Q", "Clubs", "♣"),
        new("K", "Clubs", "♣"),
        new("A", "Clubs", "♣"),
        // Diamonds
        new("2", "Diamonds", "♦"),
        new("3", "Diamonds", "♦"),
        new("4", "Diamonds", "♦"),
        new("5", "Diamonds", "♦"),
        new("6", "Diamonds", "♦"),
        new("7", "Diamonds", "♦"),
        new("8", "Diamonds", "♦"),
        new("9", "Diamonds", "♦"),
        new("10", "Diamonds", "♦"),
        new("J", "Diamonds", "♦"),
        new("Q", "Diamonds", "♦"),
        new("K", "Diamonds", "♦"),
        new("A", "Diamonds", "♦"),
        // Hearts
        new("2", "Hearts", "♥"),
        new("3", "Hearts", "♥"),
        new("4", "Hearts", "♥"),
        new("5", "Hearts", "♥"),
        new("6", "Hearts", "♥"),
        new("7", "Hearts", "♥"),
        new("8", "Hearts", "♥"),
        new("9", "Hearts", "♥"),
        new("10", "Hearts", "♥"),
        new("J", "Hearts", "♥"),
        new("Q", "Hearts", "♥"),
        new("K", "Hearts", "♥"),
        new("A", "Hearts", "♥"),
        // Spades
        new("2", "Spades", "♠"),
        new("3", "Spades", "♠"),
        new("4", "Spades", "♠"),
        new("5", "Spades", "♠"),
        new("6", "Spades", "♠"),
        new("7", "Spades", "♠"),
        new("8", "Spades", "♠"),
        new("9", "Spades", "♠"),
        new("10", "Spades", "♠"),
        new("J", "Spades", "♠"),
        new("Q", "Spades", "♠"),
        new("K", "Spades", "♠"),
        new("A", "Spades", "♠")
    ];

    public static Card[] GetCards(int count)
    {
        // make sure count is not greater than the cards collection
        count = count <= 0 || count > Cards.Length ? Cards.Length : count;

        List<Card> cards = Cards.ToList();

        // return random cards
        Card[] instances = new Card[count];
        for (int i = 0; i < count; i++)
        {
            int index = Random.Shared.Next(cards.Count);
            instances.SetValue(cards[index], i);
            cards.RemoveAt(index);
        }

        return instances;
    }
}