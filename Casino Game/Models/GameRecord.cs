using System.ComponentModel.DataAnnotations;

namespace SVassey_FinalProject_CPT206_A80H.Models
{
    public class GameRecord
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = "";

        public decimal BetAmount { get; set; }

        public decimal BalanceBefore { get; set; }

        public decimal BalanceAfter { get; set; }

        public string Result { get; set; } = "";

        public DateTime PlayedAt { get; set; } = DateTime.Now;
    }
}