namespace Pokemon_revolution_online_bot.Src.GUI
{
    partial class HomeForm
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
            label1 = new Label();
            gameScreenPanel = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 306);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // gameScreenPanel
            // 
            gameScreenPanel.BorderStyle = BorderStyle.FixedSingle;
            gameScreenPanel.ImeMode = ImeMode.NoControl;
            gameScreenPanel.Location = new Point(69, 30);
            gameScreenPanel.Margin = new Padding(0);
            gameScreenPanel.Name = "gameScreenPanel";
            gameScreenPanel.Size = new Size(800, 600);
            gameScreenPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(69, 669);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(930, 760);
            Controls.Add(button1);
            Controls.Add(gameScreenPanel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel gameScreenPanel;
        private Button button1;
    }
}