using System;

namespace SquidGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new SquidGame())
                game.Run();
        }
    }
}
