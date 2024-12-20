namespace Pokemon_revolution_online_bot.Src.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeButton = new Button();
            presetButton = new Button();
            botSettingsButton = new Button();
            fillPanel = new Panel();
            settingsButton = new Button();
            quitButton = new Button();
            mainPanel = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(24, 28, 20);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(homeButton);
            flowLayoutPanel1.Controls.Add(presetButton);
            flowLayoutPanel1.Controls.Add(botSettingsButton);
            flowLayoutPanel1.Controls.Add(fillPanel);
            flowLayoutPanel1.Controls.Add(settingsButton);
            flowLayoutPanel1.Controls.Add(quitButton);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 761);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(60, 61, 55);
            homeButton.FlatAppearance.BorderColor = Color.FromArgb(24, 28, 20);
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            homeButton.ForeColor = Color.FromArgb(236, 223, 204);
            homeButton.Location = new Point(0, 0);
            homeButton.Margin = new Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(240, 75);
            homeButton.TabIndex = 0;
            homeButton.Text = "PRO-Bot";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += HomeButton_Click;
            // 
            // presetButton
            // 
            presetButton.BackColor = Color.FromArgb(60, 61, 55);
            presetButton.FlatAppearance.BorderColor = Color.FromArgb(24, 28, 20);
            presetButton.FlatAppearance.BorderSize = 0;
            presetButton.FlatStyle = FlatStyle.Flat;
            presetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            presetButton.ForeColor = Color.FromArgb(236, 223, 204);
            presetButton.Location = new Point(0, 78);
            presetButton.Margin = new Padding(0, 3, 0, 0);
            presetButton.Name = "presetButton";
            presetButton.Size = new Size(240, 36);
            presetButton.TabIndex = 2;
            presetButton.Text = "Presets";
            presetButton.UseVisualStyleBackColor = false;
            presetButton.Click += PresetButton_Click;
            // 
            // botSettingsButton
            // 
            botSettingsButton.BackColor = Color.FromArgb(60, 61, 55);
            botSettingsButton.FlatAppearance.BorderColor = Color.FromArgb(24, 28, 20);
            botSettingsButton.FlatAppearance.BorderSize = 0;
            botSettingsButton.FlatStyle = FlatStyle.Flat;
            botSettingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botSettingsButton.ForeColor = Color.FromArgb(236, 223, 204);
            botSettingsButton.Location = new Point(0, 117);
            botSettingsButton.Margin = new Padding(0, 3, 0, 0);
            botSettingsButton.Name = "botSettingsButton";
            botSettingsButton.Size = new Size(240, 36);
            botSettingsButton.TabIndex = 1;
            botSettingsButton.Text = "Bot settings";
            botSettingsButton.UseVisualStyleBackColor = false;
            botSettingsButton.Click += BotSettingsButton_Click;
            // 
            // fillPanel
            // 
            fillPanel.CausesValidation = false;
            fillPanel.Location = new Point(0, 153);
            fillPanel.Margin = new Padding(0);
            fillPanel.Name = "fillPanel";
            fillPanel.Size = new Size(240, 526);
            fillPanel.TabIndex = 5;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(60, 61, 55);
            settingsButton.FlatAppearance.BorderColor = Color.FromArgb(24, 28, 20);
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            settingsButton.ForeColor = Color.FromArgb(236, 223, 204);
            settingsButton.Location = new Point(0, 682);
            settingsButton.Margin = new Padding(0, 3, 0, 0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(240, 36);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += SettingsButton_Click;
            // 
            // quitButton
            // 
            quitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            quitButton.BackColor = Color.FromArgb(60, 61, 55);
            quitButton.FlatAppearance.BorderColor = Color.FromArgb(24, 28, 20);
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            quitButton.ForeColor = Color.FromArgb(236, 223, 204);
            quitButton.Location = new Point(0, 721);
            quitButton.Margin = new Padding(0, 3, 0, 0);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(240, 36);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(246, 1);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(930, 760);
            mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1184, 761);
            Controls.Add(mainPanel);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button homeButton;
        private Button botSettingsButton;
        private Button presetButton;
        private Button settingsButton;
        private Button quitButton;
        private Panel fillPanel;
        private FlowLayoutPanel mainPanel;
    }
}