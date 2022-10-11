public class Cards : ICards{
    public CardSuit Suit { get; set; }
    public CardRank Rank { get; set; }
    public int Value { get; set; }
    
    public Cards(string suit, string rank, int value){
        Suit = suit;
        Rank = rank;
        Value = value;
    }
    public override string ToString(){
        return $"{Rank} of {Suit}";
    }
    
    enum  CardRank{
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
};

enum CardSuit{
    Clubs = 1,
    Diamonds = 2,
    Hearts = 3,
    Spades = 4;

}
}




public class ListOfCards(){

    public List<Cards> Deck { get; set; }
    public ListOfCards(){
        Deck = new List<Cards>();
    }
    public void AddCard(Cards card){
       if (Deck.Count < 52){
           Deck.Add(card);
       }
       else{
           throw new Exception("Invalid Suit");
       }
    }

    private bool IsCardInDeck(Cards card){
        return Deck.Contains(card);
    }

    public void RemoveCard(Cards card){
        if (IsCardInDeck(card)){
            Deck.Remove(card);
        }
        else{
            throw new Exception("Card not in deck");
        }
    }
public bool IsCardValid(Cards card){
    if ((card.Suit == CardSuit.Clubs || card.Suit == CardSuit.Diamonds || card.Suit == CardSuit.Hearts || card.Suit == CardSuit.Spades) and
    (card.Rank == CardRank.Ace || card.Rank == CardRank.Two || card.Rank == CardRank.Three || card.Rank == CardRank.Four || card.Rank == CardRank.Five || card.Rank == CardRank.Six || card.Rank == CardRank.Seven || card.Rank == CardRank.Eight || card.Rank == CardRank.Nine || card.Rank == CardRank.Ten || card.Rank == CardRank.Jack || card.Rank == CardRank.Queen || card.Rank == CardRank.King)){
        return true;
    } 
    return false;
}

    public void RemoveCard(Cards card){
        Deck.Remove(card);
    }
    public void Shuffle(){
        Random rand = new Random();
        for (int i = 0; i < Deck.Count; i++){
            int r = rand.Next(0, Deck.Count);
            Cards temp = Deck[i];
            Deck[i] = Deck[r];
            Deck[r] = temp;
        }
    }
    public void PrintDeck(){
        foreach (Cards card in Deck){
            Console.WriteLine(card);
        }
    }
}