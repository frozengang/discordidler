using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiscordIdler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Program.M = this;
        }

        private void TokensButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = Open.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Core.TOKENS = new List<string>(File.ReadAllLines(Open.FileName));
                Core.Logs += Environment.NewLine + "Считано " + Core.TOKENS.Count + " токенов";
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            /*
            if (Core.TOKENS.Count == 0)
            {
                Core.Logs += Environment.NewLine + "Вы не загрузили токены";
                return;
            }
            else if (Core.PROXY.Count == 0)
            {
                Core.Logs += Environment.NewLine + "Вы не загрузили прокси";
                return;
            }
            else if (UseCustom.Checked)
            {
                if (Core.CUSTOM.Count == 0)
                {
                    Core.Logs += Environment.NewLine + "Вы не загрузили кастомные статусы";
                    return;
                }
            }

            if (Program.M.StatusList.SelectedIndex == 0)
            {
                Core.Status = "online";
            }
            else if (Program.M.StatusList.SelectedIndex == 1)
            {
                Core.Status = "idle";
            }
            else if (Program.M.StatusList.SelectedIndex == 2)
            {
                Core.Status = "dnd";
            }
            else if (Program.M.StatusList.SelectedIndex == 3)
            {
                Core.Status = "invisible";
            }
            else if (Program.M.StatusList.SelectedIndex == 4)
            {
                if (Core.CUSTOM.Count == 0)
                {
                    Core.Logs += Environment.NewLine + "Вы не загрузили кастомные статусы";
                    return;
                }
                else
                {
                    Core.Status = Core.CUSTOM[Core.CUSTOM_INDEX];
                    Core.CUSTOM_INDEX++;
                }
            }

            Start.Enabled = false;
            Core.Logs += Environment.NewLine + "Запуск...";
            new Thread(new ThreadStart(Network.ChangeStatus)).Start(); */

            Network.SetOnline();
        }

        private void Write(object sender, EventArgs e)
        {
            Log.Text = Core.Logs;
        }

        private void _Load(object sender, EventArgs e)
        {
            Core.StatusList.Add("online");
            Core.StatusList.Add("idle");
            Core.StatusList.Add("dnd");
            Core.StatusList.Add("invisible");

            Core.Logs += "Загружен...";
        }

        private void ProxyButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = Open.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Core.PROXY = new List<string>(File.ReadAllLines(Open.FileName));
                Core.Logs += Environment.NewLine + "Считано " + Core.PROXY.Count + " прокси";
            }
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = Open.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Core.CUSTOM = new List<string>(File.ReadAllLines(Open.FileName));
                
                foreach (string s in Core.CUSTOM)
                {
                    Core.StatusList.Add(Core.CUSTOM[Core.CUSTOM_INDEX]);
                    Core.CUSTOM_INDEX++;
                }

                Core.Logs += Environment.NewLine + "Считано " + Core.CUSTOM.Count + " кастомных статусов";
                Core.Logs += Environment.NewLine + "Всего статусов: " + Core.StatusList.Count;
            }
        }

        private void BlockOrPass(object sender, EventArgs e)
        {
            if (UseCustom.Checked)
            {
                CustomButton.Enabled = true;
            }
            else
            {
                CustomButton.Enabled = false;
            }
        }

        private void BlockOrPass2(object sender, EventArgs e)
        {
            if (Randomizer.Checked)
            {
                StatusList.Enabled = false;
            }
            else
            {
                StatusList.Enabled = true;
            }
        }
    }
}
