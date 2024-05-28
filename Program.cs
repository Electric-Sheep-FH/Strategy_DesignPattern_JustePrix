namespace Strategy_DesignPattern_JustePrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();

            //game.SetStrategy(new IdiotStrategy());

            game.LauchGame();
        }
    }
}
