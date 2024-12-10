using System.Runtime.CompilerServices;

namespace blackjack;

public class Collection
{
    protected List<Card> cards;

    public Collection()
    {
        this.cards = new List<Card>();
    }

    public Collection(List<Card> cards)
    {
        this.cards = cards;
    }
}



