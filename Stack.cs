using System.Security.Cryptography;

namespace blackjack;

// describes a stack of cards, arranged like a deck where you can draw from them.
// i'm not calling it a deck, as the word "deck" refers to a set of 52 specific cards.
public class Stack
{
    protected Queue<Card> cards;

    public Stack(Queue<Card> cards)
    {
        this.cards = cards;
    }

    // Shuffles the collection of cards
    // needs to be able to throw an error if no cards are remaining
    public void Shuffle()
    {
        List<Card> oldStack = cards.ToList();
        Queue<Card> shuffledStack = new Queue<Card>();
        var rng = new Random();
        
        // This uses the naïve Fisher-Yates shuffle algorithm.
        while(oldStack.Count > 0)
        {
            int k = rng.Next(oldStack.Count);
            shuffledStack.Enqueue(oldStack.ElementAt(k));
            oldStack.RemoveAt(k);
        }
        cards = shuffledStack;
    }
    
    // draws a card from the top of a collection. should i make this part of a stack of cards instead?
    // also, this needs to be able to throw an error if there are no cards remaining
    public Card Draw()
    {
        return cards.Dequeue();
    }

    public override string ToString()
    {
        return cards.Aggregate<Card, String, String>("", (string acc, Card card) => acc + card.ToString() + ", ", (string acc) => acc);
    }
    
}
