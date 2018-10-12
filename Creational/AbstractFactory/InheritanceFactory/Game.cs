namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// The Abstract Product
    /// </summary>
    internal abstract class Game
    {
        protected string gameDifficulty;

        public abstract void AnnounceWinner();
    }
}