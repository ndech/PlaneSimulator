﻿namespace PlaneSimulator
{
    using System.Globalization;
    using System.Threading;
    internal static class EntryPoint
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Game game = new Game();
            game.Run();
            game.Dispose();
        }
    }
}