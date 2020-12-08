using System;

namespace DiscordIdler
{
    static class Program
    {
        public static Main M;

        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
