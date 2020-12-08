using Leaf.xNet;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DiscordIdler
{
    internal class Network
    {
        public static void SetOnline()
        {
            using (var c = new HttpRequest())
            {
                foreach (string s in Core.TOKENS)
                {
                    c.Proxy = ProxyClient.DebugHttpProxy;
                    c.AddHeader("Authorization", Core.TOKENS[Core.TOKENS_INDEX]);

                    string JSON =
                        "{\n" +

                        "  \"content\": \"1\"," +
                        "  \"nonce\": null," + 
                        "  \"tts\": false" +

                        "\n}";

                    try
                    {
                        HttpResponse r = c.Post("https://discord.com/api/v8/channels/782350559301861446/messages", JSON, "application/json");

                        if (r.StatusCode == HttpStatusCode.OK)
                        {
                            Core.Logs += Environment.NewLine + "Онлайн для аккаунта №" + Core.TOKENS_INDEX + " установлен";
                        }
                        Core.TOKENS_INDEX++;
                    }
                    catch (Exception e) { Core.Logs += Environment.NewLine + "Ошибка при попытке установить онлайн-статус"; MessageBox.Show(e.ToString()); }
                }
            }
        }

        public static void RunRandomizer()
        {
            if (Program.M.Randomizer.Checked)
            {
                Random r = new Random();
                Core.Status = Core.StatusList[r.Next(0, Core.StatusList.Count)];
            }
        }

        public static void ChangeStatus()
        {
            if (Core.TOKENS.Count != 0)
            {
                foreach (string s in Core.TOKENS)
                {
                    string JSON = null;
                    RunRandomizer();

                    if (Core.Status != "online" && Core.Status != "idle" && Core.Status != "dnd" && Core.Status != "invisible")
                    {
                        JSON =
                           "{" +

                            "\n  \"custom_status\": {\n    \"text\": \"" + Core.Status + "\"\n  }\n" +

                            "}";
                    }
                    else
                    {
                        JSON =
                            "{" +

                                $"\n  \"status\": \"{Core.Status}\"\n" +

                            "}";
                    }

                    using (var c = new HttpRequest())
                    {
                        c.Proxy = HttpProxyClient.Parse(Core.PROXY[Core.PROXY_INDEX]);
                        c.Proxy.ConnectTimeout = 10000;

                        c.AddHeader("Host", "discordapp.com");
                        c.AddHeader("Connection", "keep-alive");
                        c.AddHeader("Content-Length", JSON.Length.ToString());
                        c.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjAuMC4zMDciLCJvc192ZXJzaW9uIjoiMTAuMC4xODM2MyIsIm9zX2FyY2giOiJ4NjQiLCJjbGllbnRfYnVpbGRfbnVtYmVyIjo3MDY0OSwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");
                        c.AddHeader("Origin", "https://discordapp.com");
                        c.AddHeader("Authorization", Core.TOKENS[Core.TOKENS_INDEX]);
                        c.AddHeader("Accept-Language", "ru");
                        c.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.307 Chrome/78.0.3904.130 Electron/7.3.2 Safari/537.36");
                        c.AddHeader("Content-Type", "application/json");
                        c.AddHeader("Accept", "*/*");
                        c.AddHeader("Sec-Fetch-Site", "same-origin");
                        c.AddHeader("Sec-Fetch-Mode", "cors");
                        c.AddHeader("Referer", "https://discordapp.com");
                        c.AddHeader("Accept-Encoding", "gzip, deflate, br");

                        try
                        {
                            HttpResponse r = c.Patch("https://discordapp.com/api/v8/users/@me/settings", JSON, "application/json");

                            if (r.StatusCode == HttpStatusCode.OK)
                            {
                                Core.Logs += Environment.NewLine + "Статус аккаунта №" + Core.TOKENS_INDEX + " изменён" + $" ({r.StatusCode})";
                            }
                            else if (r.StatusCode == HttpStatusCode.BadGateway)
                            {
                                Core.Logs += Environment.NewLine + "Запрещен доступ с текущего IP для аккаунта №" + Core.TOKENS_INDEX + $" ({r.StatusCode})";
                                Core.PROXY_INDEX++;
                            }
                            else
                            {
                                Core.Logs += Environment.NewLine + "Ошибка при изменении статуса для аккаунта №" + Core.TOKENS_INDEX + $" ({r.StatusCode})";
                                new Thread(new ThreadStart(Network.ChangeStatus)).Start();
                            }
                            Core.TOKENS_INDEX++;
                        }
                        catch (Exception e) { Core.Logs += Environment.NewLine + "Ошибка при создании запроса"; MessageBox.Show(e.ToString()); };
                    }
                }
            }
        }
    }
}
