using SVassey_FinalProject_CPT206_A80H.Models;

namespace SVassey_FinalProject_CPT206_A80H.Services
{
    public class BlackjackService
    {
        public BlackjackGame Game { get; set; } = new BlackjackGame();

        public void NewGame()
        {
            Game.StartGame();
        }

        public void Hit()
        {
            Game.Hit();
        }

        public void Stand()
        {
            Game.Stand();
        }
    }
}