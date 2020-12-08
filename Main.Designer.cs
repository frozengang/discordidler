namespace DiscordIdler
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.TokensButton = new Guna.UI2.WinForms.Guna2Button();
            this.StatusList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.decor = new Guna.UI2.WinForms.Guna2Button();
            this.Log = new Guna.UI2.WinForms.Guna2TextBox();
            this.Start = new Guna.UI2.WinForms.Guna2Button();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.LW = new System.Windows.Forms.Timer(this.components);
            this.Randomizer = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ProxyButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomButton = new Guna.UI2.WinForms.Guna2Button();
            this.UseCustom = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Title = "Discord Idler";
            // 
            // TokensButton
            // 
            this.TokensButton.CheckedState.Parent = this.TokensButton;
            this.TokensButton.CustomImages.Parent = this.TokensButton;
            this.TokensButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TokensButton.ForeColor = System.Drawing.Color.White;
            this.TokensButton.HoverState.Parent = this.TokensButton;
            this.TokensButton.Location = new System.Drawing.Point(12, 12);
            this.TokensButton.Name = "TokensButton";
            this.TokensButton.ShadowDecoration.Parent = this.TokensButton;
            this.TokensButton.Size = new System.Drawing.Size(139, 32);
            this.TokensButton.TabIndex = 0;
            this.TokensButton.Text = "Выбрать токены";
            this.TokensButton.Click += new System.EventHandler(this.TokensButton_Click);
            // 
            // StatusList
            // 
            this.StatusList.BackColor = System.Drawing.Color.Transparent;
            this.StatusList.BorderThickness = 0;
            this.StatusList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusList.FocusedColor = System.Drawing.Color.Empty;
            this.StatusList.FocusedState.Parent = this.StatusList;
            this.StatusList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusList.FormattingEnabled = true;
            this.StatusList.HoverState.Parent = this.StatusList;
            this.StatusList.ItemHeight = 25;
            this.StatusList.Items.AddRange(new object[] {
            "В сети",
            "Не активен",
            "Не беспокоить",
            "Невидимка",
            "Кастомный"});
            this.StatusList.ItemsAppearance.Parent = this.StatusList;
            this.StatusList.Location = new System.Drawing.Point(157, 11);
            this.StatusList.Name = "StatusList";
            this.StatusList.ShadowDecoration.Parent = this.StatusList;
            this.StatusList.Size = new System.Drawing.Size(155, 31);
            this.StatusList.StartIndex = 0;
            this.StatusList.TabIndex = 1;
            // 
            // decor
            // 
            this.decor.CheckedState.Parent = this.decor;
            this.decor.CustomImages.Parent = this.decor;
            this.decor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.decor.ForeColor = System.Drawing.Color.White;
            this.decor.HoverState.Parent = this.decor;
            this.decor.Location = new System.Drawing.Point(157, 12);
            this.decor.Name = "decor";
            this.decor.ShadowDecoration.Parent = this.decor;
            this.decor.Size = new System.Drawing.Size(155, 32);
            this.decor.TabIndex = 2;
            // 
            // Log
            // 
            this.Log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Log.DefaultText = "";
            this.Log.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.DisabledState.Parent = this.Log;
            this.Log.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.FocusedState.Parent = this.Log;
            this.Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Log.HoverState.Parent = this.Log;
            this.Log.Location = new System.Drawing.Point(12, 126);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.PasswordChar = '\0';
            this.Log.PlaceholderText = "";
            this.Log.ReadOnly = true;
            this.Log.SelectedText = "";
            this.Log.ShadowDecoration.Parent = this.Log;
            this.Log.Size = new System.Drawing.Size(300, 313);
            this.Log.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.CheckedState.Parent = this.Start;
            this.Start.CustomImages.Parent = this.Start;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.HoverState.Parent = this.Start;
            this.Start.Location = new System.Drawing.Point(12, 445);
            this.Start.Name = "Start";
            this.Start.ShadowDecoration.Parent = this.Start;
            this.Start.Size = new System.Drawing.Size(300, 32);
            this.Start.TabIndex = 4;
            this.Start.Text = "Включить";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Close
            // 
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(12, 483);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(300, 32);
            this.Close.TabIndex = 5;
            this.Close.Text = "Закрыть";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LW
            // 
            this.LW.Enabled = true;
            this.LW.Interval = 500;
            this.LW.Tick += new System.EventHandler(this.Write);
            // 
            // Randomizer
            // 
            this.Randomizer.AutoSize = true;
            this.Randomizer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Randomizer.CheckedState.BorderRadius = 2;
            this.Randomizer.CheckedState.BorderThickness = 0;
            this.Randomizer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Randomizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Randomizer.Location = new System.Drawing.Point(163, 65);
            this.Randomizer.Name = "Randomizer";
            this.Randomizer.Size = new System.Drawing.Size(149, 17);
            this.Randomizer.TabIndex = 6;
            this.Randomizer.Text = "Рандомизация статусов";
            this.Randomizer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Randomizer.UncheckedState.BorderRadius = 2;
            this.Randomizer.UncheckedState.BorderThickness = 0;
            this.Randomizer.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Randomizer.UseVisualStyleBackColor = true;
            this.Randomizer.CheckStateChanged += new System.EventHandler(this.BlockOrPass2);
            // 
            // ProxyButton
            // 
            this.ProxyButton.CheckedState.Parent = this.ProxyButton;
            this.ProxyButton.CustomImages.Parent = this.ProxyButton;
            this.ProxyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProxyButton.ForeColor = System.Drawing.Color.White;
            this.ProxyButton.HoverState.Parent = this.ProxyButton;
            this.ProxyButton.Location = new System.Drawing.Point(12, 50);
            this.ProxyButton.Name = "ProxyButton";
            this.ProxyButton.ShadowDecoration.Parent = this.ProxyButton;
            this.ProxyButton.Size = new System.Drawing.Size(139, 32);
            this.ProxyButton.TabIndex = 7;
            this.ProxyButton.Text = "Выбрать прокси";
            this.ProxyButton.Click += new System.EventHandler(this.ProxyButton_Click);
            // 
            // CustomButton
            // 
            this.CustomButton.CheckedState.Parent = this.CustomButton;
            this.CustomButton.CustomImages.Parent = this.CustomButton;
            this.CustomButton.Enabled = false;
            this.CustomButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomButton.ForeColor = System.Drawing.Color.White;
            this.CustomButton.HoverState.Parent = this.CustomButton;
            this.CustomButton.Location = new System.Drawing.Point(12, 88);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.ShadowDecoration.Parent = this.CustomButton;
            this.CustomButton.Size = new System.Drawing.Size(139, 32);
            this.CustomButton.TabIndex = 8;
            this.CustomButton.Text = "Загрузить статусы";
            this.CustomButton.Click += new System.EventHandler(this.CustomButton_Click);
            // 
            // UseCustom
            // 
            this.UseCustom.AutoSize = true;
            this.UseCustom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UseCustom.CheckedState.BorderRadius = 2;
            this.UseCustom.CheckedState.BorderThickness = 0;
            this.UseCustom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UseCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UseCustom.Location = new System.Drawing.Point(163, 88);
            this.UseCustom.Name = "UseCustom";
            this.UseCustom.Size = new System.Drawing.Size(128, 17);
            this.UseCustom.TabIndex = 9;
            this.UseCustom.Text = "Кастомные статусы";
            this.UseCustom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UseCustom.UncheckedState.BorderRadius = 2;
            this.UseCustom.UncheckedState.BorderThickness = 0;
            this.UseCustom.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UseCustom.UseVisualStyleBackColor = true;
            this.UseCustom.CheckStateChanged += new System.EventHandler(this.BlockOrPass);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 523);
            this.Controls.Add(this.UseCustom);
            this.Controls.Add(this.CustomButton);
            this.Controls.Add(this.ProxyButton);
            this.Controls.Add(this.Randomizer);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.TokensButton);
            this.Controls.Add(this.decor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Idler";
            this.Load += new System.EventHandler(this._Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Open;
        private Guna.UI2.WinForms.Guna2Button TokensButton;
        private Guna.UI2.WinForms.Guna2Button decor;
        public Guna.UI2.WinForms.Guna2TextBox Log;
        private Guna.UI2.WinForms.Guna2Button Start;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Timer LW;
        public Guna.UI2.WinForms.Guna2ComboBox StatusList;
        public Guna.UI2.WinForms.Guna2CheckBox Randomizer;
        private Guna.UI2.WinForms.Guna2Button ProxyButton;
        private Guna.UI2.WinForms.Guna2Button CustomButton;
        public Guna.UI2.WinForms.Guna2CheckBox UseCustom;
    }
}

