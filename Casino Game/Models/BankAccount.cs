using System.ComponentModel.DataAnnotations;

namespace SVassey_FinalProject_CPT206_A80H.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = "";

        public decimal Balance { get; set; } = 1000.00m;
    }
}