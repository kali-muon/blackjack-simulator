namespace blackjack;

class Simulator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        // Card card = new Card(Value.Queen, Suit.Spades);
        // Console.WriteLine(card.ToString());
        
        Queue<Card> cardQueue = new Queue<Card>();
        cardQueue.Enqueue(new Card(Value.Ace, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Two, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Three, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Four, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Five, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Six, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Seven, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Eight, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Nine, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Ten, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Jack, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Queen, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.King, Suit.Spades));
        cardQueue.Enqueue(new Card(Value.Ace, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Two, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Three, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Four, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Five, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Six, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Seven, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Eight, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Nine, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Ten, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Jack, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Queen, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.King, Suit.Hearts));
        cardQueue.Enqueue(new Card(Value.Ace, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Two, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Three, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Four, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Five, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Six, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Seven, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Eight, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Nine, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Ten, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Jack, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Queen, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.King, Suit.Clubs));
        cardQueue.Enqueue(new Card(Value.Ace, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Two, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Three, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Four, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Five, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Six, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Seven, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Eight, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Nine, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Ten, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Jack, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.Queen, Suit.Diamonds));
        cardQueue.Enqueue(new Card(Value.King, Suit.Diamonds));

        Stack stack = new Stack(cardQueue);
        Console.WriteLine("stack contents: " + stack.ToString());
        stack.Shuffle();
        Console.WriteLine("shuffled stack contents: " + stack.ToString());
    }
}
