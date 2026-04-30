using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SVassey_FinalProject_CPT206_A80H.Data;
using SVassey_FinalProject_CPT206_A80H.Models;

namespace SVassey_FinalProject_CPT206_A80H.Pages.Stats
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public int TotalGames { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Pushes { get; set; }
        public decimal WinPercentage { get; set; }
        public decimal TotalBet { get; set; }
        public decimal ProfitLoss { get; set; }

        public List<GameRecord> RecentGames { get; set; } = new();

        public async Task OnGet()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return;
            }

            var records = _context.GameRecords
                .Where(x => x.UserId == user.Id)
                .OrderByDescending(x => x.PlayedAt)
                .ToList();

            // Count total games played
            TotalGames = records.Count;

            // Count wins based on result messages
            Wins = records.Count(x =>
                x.Result.Contains("You win") ||
                x.Result.Contains("Dealer busted"));

            Pushes = records.Count(x =>
                x.Result.Contains("Push"));

            Losses = records.Count(x =>
                x.Result.Contains("Dealer wins") ||
                x.Result.Contains("You busted"));

            // Calculate win percentage
            if (TotalGames > 0)
            {
                WinPercentage = Math.Round((decimal)Wins / TotalGames * 100, 2);
            }

            // Add up all money bet across games
            TotalBet = records.Sum(x => x.BetAmount);

            // Calculate total profit or loss from all games
            ProfitLoss = records.Sum(x =>
            {
                if (x.Result.Contains("You win") || x.Result.Contains("Dealer busted"))
                {
                    return x.BetAmount;
                }

                if (x.Result.Contains("Push"))
                {
                    return 0;
                }

                return -x.BetAmount;
            });

            // Show only the 10 most recent games
            RecentGames = records.Take(10).ToList();
        }
    }
}