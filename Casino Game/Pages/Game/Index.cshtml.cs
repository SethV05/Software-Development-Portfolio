using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SVassey_FinalProject_CPT206_A80H.Data;
using SVassey_FinalProject_CPT206_A80H.Models;
using System.Text.Json;

namespace SVassey_FinalProject_CPT206_A80H.Pages.Game
{
    // User must be logged in to play
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public BlackjackGame Game { get; set; } = new BlackjackGame();

        [BindProperty]
        public decimal BetAmount { get; set; }

        public decimal Balance { get; set; }

        public async Task<IActionResult> OnGet()
        {
            LoadGame();

            // Get user bank account and display balance
            var account = await GetOrCreateBankAccount();
            Balance = account.Balance;

            return Page();
        }

        // Runs when the user starts a new Blackjack game
        public async Task<IActionResult> OnPostNewGame()
        {
            var account = await GetOrCreateBankAccount();

            // Validations
            if (BetAmount <= 0)
            {
                TempData["Error"] = "Bet must be greater than 0.";
                return RedirectToPage();
            }

            if (BetAmount > account.Balance)
            {
                TempData["Error"] = "You do not have enough money for that bet.";
                return RedirectToPage();
            }

            // Take the bet from the user's balance
            account.Balance -= BetAmount;
            await _context.SaveChangesAsync();

            Game = new BlackjackGame();
            Game.StartGame();

            // Save the current game and bet
            SaveGame();
            HttpContext.Session.SetString("Bet", BetAmount.ToString());

            return RedirectToPage();
        }

        public IActionResult OnPostHit()
        {
            LoadGame();

            Game.Hit();

            SaveGame();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostStand()
        {
            LoadGame();

            Game.Stand();

            var account = await GetOrCreateBankAccount();

            decimal bet = 0;

            // Get saved bet amount
            string? betText = HttpContext.Session.GetString("Bet");

            if (!string.IsNullOrEmpty(betText))
            {
                decimal.TryParse(betText, out bet);
            }

            // Save balance before payout
            decimal before = account.Balance;

            string result = Game.ResultMessage;

            // User Payout Logic
            if (result.Contains("You win"))
            {
                account.Balance += bet * 2;
            }

            else if (result.Contains("Push"))
            {
                account.Balance += bet;
            }


            // Save balance after payout
            decimal after = account.Balance;

            // Record the finished game in the database for stats
            _context.GameRecords.Add(new GameRecord
            {
                UserId = account.UserId,
                BetAmount = bet,
                BalanceBefore = before,
                BalanceAfter = after,
                Result = result
            });

            // Save balance and game record
            await _context.SaveChangesAsync();

            // Save final game state
            SaveGame();

            return RedirectToPage();
        }

        // Saves Blackjack game into session so it does not reset every page refresh(this was a problem lol)
        private void SaveGame()
        {
            HttpContext.Session.SetString("BlackjackGame", JsonSerializer.Serialize(Game));
        }

        // Loads Blackjack game from session
        private void LoadGame()
        {
            string? gameText = HttpContext.Session.GetString("BlackjackGame");

            if (!string.IsNullOrEmpty(gameText))
            {
                Game = JsonSerializer.Deserialize<BlackjackGame>(gameText) ?? new BlackjackGame();
            }
            else
            {
                Game = new BlackjackGame();
            }
        }

        // Gets the logged-in user's bank account or creates one if they do not have one
        private async Task<BankAccount> GetOrCreateBankAccount()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                throw new Exception("User is not logged in.");
            }

            // Find this user's bank account
            var account = _context.BankAccounts.FirstOrDefault(x => x.UserId == user.Id);

            // If no account exists, create one with starting money
            if (account == null)
            {
                account = new BankAccount
                {
                    UserId = user.Id,
                    Balance = 1000.00m
                };

                _context.BankAccounts.Add(account);
                await _context.SaveChangesAsync();
            }

            return account;
        }
    }
}