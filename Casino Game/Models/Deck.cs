namespace SVassey_FinalProject_CPT206_A80H.Models
{
    public class Deck
    {
        private List<Card> Cards { get; set; } = new List<Card>();
        private Random Random { get; set; } = new Random();

        public Deck()
        {
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Cards.Add(new Card
                    {
                        Suit = suit,
                        Rank = rank
                    });
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(card => Random.Next()).ToList();
        }

        public Card DrawCard()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}