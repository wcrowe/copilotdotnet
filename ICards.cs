namespace copilotdotnet; 

interface ICards{
    Cards.CardSuit Suit { get; set; }
    Cards.CardRank Rank { get; set; }
    int Value { get; set; }
}