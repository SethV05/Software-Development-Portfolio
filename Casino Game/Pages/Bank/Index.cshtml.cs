using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SVassey_FinalProject_CPT206_A80H.Data;
using SVassey_FinalProject_CPT206_A80H.Models;

namespace SVassey_FinalProject_CPT206_A80H.Pages.Bank
{
    // Only logged-in users can access this page
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

        [BindProperty]
        public decimal? AddAmount { get; set; }

        // Holds current balance
        public decimal Balance { get; set; }

        public async Task<IActionResult> OnGet()
        {
            // Get the user's bank account (or create one if it doesn't exist)
            var account = await GetOrCreateBankAccount();

            Balance = account.Balance;

            AddAmount = null;

            return Page();
        }

        // Runs when user clicks Add Funds
        public async Task<IActionResult> OnPostAddFunds()
        {
            var account = await GetOrCreateBankAccount();

            // Validation
            if (AddAmount == null || AddAmount <= 0)
            {
                TempData["Error"] = "Amount must be greater than $0.";
                return RedirectToPage();
            }

            // Cant deposit to much
            if (AddAmount > 10000)
            {
                TempData["Error"] = "You can only add up to $10,000 at one time.";
                return RedirectToPage();
            }

            // Adds money to the user's balance
            account.Balance += AddAmount.Value;

            _context.SaveChanges();

            TempData["Success"] = $"${AddAmount.Value.ToString("0.00")} added successfully.";

            return RedirectToPage();
        }

        // Gets the user's account OR creates one if it doesn't exist
        private async Task<BankAccount> GetOrCreateBankAccount()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                throw new Exception("User is not logged in.");
            }

            // Look for existing account in database
            var account = _context.BankAccounts.FirstOrDefault(x => x.UserId == user.Id);

            if (account == null)
            {
                account = new BankAccount
                {
                    UserId = user.Id,

                    // Give new users starting money
                    Balance = 1000.00m
                };

                _context.BankAccounts.Add(account);
                _context.SaveChanges();
            }

            return account;
        }
    }
}