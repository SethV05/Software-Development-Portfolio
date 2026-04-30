namespace SVassey_FinalProject_CPT206_A80H.Models
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public int Value
        {
            get
            {
                if (Rank == "ace") return 11;
                if (Rank == "king" || Rank == "queen" || Rank == "jack") return 10;
                return int.Parse(Rank);
            }
        }

        public string ImagePath
        {
            get
            {
                return $"/images/cards/{Rank}_of_{Suit}.png";
            }
        }
    }
}