namespace blackjack;

public enum Suit
{
    Spades,
    Hearts,
    Clubs,
    Diamonds
}

public enum Value
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

public class Card
{
    private readonly Value value;
    private readonly Suit suit;

    public Card(Value value, Suit suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public override string ToString()
    {
        return "Card: " + value + " of " + suit;
    }
}
