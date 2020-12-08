using Leaf.xNet;
using System.Collections.Generic;
using System.Diagnostics;

namespace DiscordIdler
{
    internal class Core
    {
        public static List<string> TOKENS = new List<string>();
        public static List<string> PROXY = new List<string>();
        public static List<string> CUSTOM = new List<string>();
        public static List<string> StatusList = new List<string>();

        public static int TOKENS_INDEX = 0;
        public static int PROXY_INDEX = 0;
        public static int CUSTOM_INDEX = 0;

        public static string Logs { get; set; }

        public static string Status { get; set; }
    }
}
