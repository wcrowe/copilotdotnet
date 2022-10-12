using copilotdotnet;

public class Cards : ICards {
    public CardSuit Suit { get; set; }
    public CardRank Rank { get; set; }
    public int Value { get; set; }

    public Cards(CardSuit suit, CardRank rank, int value) {
        Suit = suit;
        Rank = rank;
        Value = value;
    }

    public override string ToString() {
        return $"{Rank} of {Suit}";
    }

    public enum CardRank {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum CardSuit {
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
        Spades = 4
    }
}

public class ListOfCards {
    public List<Cards> Deck { get; set; }

    public ListOfCards() {
        Deck = new List<Cards>();
    }

    public void AddCard(Cards card) {
        if (Deck.Count < 52) {
            Deck.Add(card);
        }
        else {
            throw new Exception("Invalid Suit");
        }
    }

    private bool IsCardInDeck(Cards card) {
        return Deck.Contains(card);
    }

    public void RemoveCard(Cards card) {
        if (IsCardInDeck(card)) {
            Deck.Remove(card);
        }
        else {
            throw new Exception("Card not in deck");
        }
    }

    bool IsCardValid(Cards card) {
        if ((card.Suit == Cards.CardSuit.Clubs || card.Suit == Cards.CardSuit.Diamonds || card.Suit == Cards.CardSuit.Hearts ||
             card.Suit == Cards.CardSuit.Spades) &&
        (card.Rank == Cards.CardRank.Ace || card.Rank == Cards.CardRank.Two || card.Rank == Cards.CardRank.Three ||
         card.Rank == Cards.CardRank.Four || card.Rank == Cards.CardRank.Five || card.Rank == Cards.CardRank.Six ||
         card.Rank == Cards.CardRank.Seven || card.Rank == Cards.CardRank.Eight || card.Rank == Cards.CardRank.Nine ||
         card.Rank == Cards.CardRank.Ten || card.Rank == Cards.CardRank.Jack || card.Rank == Cards.CardRank.Queen ||
         card.Rank == Cards.CardRank.King)){
            return true;
        }
        return false;
    }

    // public void RemoveCard(Cards card) {
    //     Deck.Remove(card);
    // }

    public void Shuffle() {
        Random rand = new Random();
        for (int i = 0; i < Deck.Count; i++) {
            int r = rand.Next(0, Deck.Count);
            // Cards temp = Deck[i];
            // Deck[i] = Deck[r];
            // Deck[r] = temp;
            (Deck[i], Deck[r]) = (Deck[r], Deck[i]);
        }
    }

    public void PrintDeck() {
        foreach (Cards card in Deck) {
            Console.WriteLine(card);
        }
    }
}