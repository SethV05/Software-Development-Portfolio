namespace SVassey_FinalProject_CPT206_A80H.Models
{
    public class BlackjackGame
    {
        public Deck Deck { get; set; } = new Deck();

        public List<Card> PlayerHand { get; set; } = new List<Card>();
        public List<Card> DealerHand { get; set; } = new List<Card>();

        public bool IsGameOver { get; set; }

        public string ResultMessage { get; set; } = "";

        public void StartGame()
        {
            // Reset everything
            Deck = new Deck();
            PlayerHand.Clear();
            DealerHand.Clear();
            IsGameOver = false;
            ResultMessage = "";

            // Deal 2 cards
            PlayerHand.Add(Deck.DrawCard());
            DealerHand.Add(Deck.DrawCard());
            PlayerHand.Add(Deck.DrawCard());
            DealerHand.Add(Deck.DrawCard());


            if (GetPlayerTotal() == 21)
            {
                Stand();
            }
        }


        public void Hit()
        {
            if (IsGameOver)
            {
                return;
            }

            PlayerHand.Add(Deck.DrawCard());

            // Check if player busted
            if (GetPlayerTotal() > 21)
            {
                IsGameOver = true;
                ResultMessage = "You busted. Dealer wins.";
            }
        }


        public void Stand()
        {
            if (IsGameOver)
            {
                return;
            }

   
            while (GetDealerTotal() < 17)
            {
                DealerHand.Add(Deck.DrawCard());
            }

            // Get final totals
            int playerTotal = GetPlayerTotal();
            int dealerTotal = GetDealerTotal();

            IsGameOver = true;


            if (dealerTotal > 21)
            {
                ResultMessage = "Dealer busted. You win!";
            }
            else if (playerTotal > dealerTotal)
            {
                ResultMessage = "You win!";
            }
            else if (playerTotal < dealerTotal)
            {
                ResultMessage = "Dealer wins.";
            }
            else
            {
                ResultMessage = "Push. It is a tie.";
            }
        }

        public int GetPlayerTotal()
        {
            return CalculateHandTotal(PlayerHand);
        }

        public int GetDealerTotal()
        {
            return CalculateHandTotal(DealerHand);
        }

        // Calculates total value of a hand
        private int CalculateHandTotal(List<Card> hand)
        {
            // Add all card values together
            int total = hand.Sum(card => card.Value);

            // Ace Logic
            int aceCount = hand.Count(card => card.Rank == "ace");

            // If total is over 21, reduce ace values from 11 to 1
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }
    }
}