namespace blackjack;

class Simulator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        Card card = new Card(Value.Queen, Suit.Spades);
        Console.WriteLine(card.ToString());
    }
}
