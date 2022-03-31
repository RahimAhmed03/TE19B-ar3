using System;

namespace MonoAsteroids
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MonoAsteroids())
                game.Run();
        }
    }
}
