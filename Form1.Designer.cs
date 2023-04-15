namespace Lottery
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ControlGame = new System.Windows.Forms.CheckBox();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.NameOfGame = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.FAQButton = new System.Windows.Forms.Button();
            this.Bu12 = new System.Windows.Forms.Button();
            this.Bu21 = new System.Windows.Forms.Button();
            this.Bu22 = new System.Windows.Forms.Button();
            this.Bu11 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.CreditButton);
            this.tabPage1.Controls.Add(this.ControlGame);
            this.tabPage1.Controls.Add(this.ScoreCount);
            this.tabPage1.Controls.Add(this.ScoreText);
            this.tabPage1.Controls.Add(this.NameOfGame);
            this.tabPage1.Controls.Add(this.CancelButton);
            this.tabPage1.Controls.Add(this.PickUpButton);
            this.tabPage1.Controls.Add(this.BuyTicketButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лотерея";
            // 
            // ControlGame
            // 
            this.ControlGame.AutoSize = true;
            this.ControlGame.Location = new System.Drawing.Point(8, 41);
            this.ControlGame.Name = "ControlGame";
            this.ControlGame.Size = new System.Drawing.Size(131, 17);
            this.ControlGame.TabIndex = 10;
            this.ControlGame.Text = "Контрольный режим";
            this.ControlGame.UseVisualStyleBackColor = true;
            this.ControlGame.Visible = false;
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.ScoreCount.Location = new System.Drawing.Point(271, 110);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(0, 17);
            this.ScoreCount.TabIndex = 9;
            this.ScoreCount.Visible = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.ScoreText.Location = new System.Drawing.Point(226, 110);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(47, 17);
            this.ScoreText.TabIndex = 8;
            this.ScoreText.Text = "счет:";
            this.ScoreText.Visible = false;
            // 
            // NameOfGame
            // 
            this.NameOfGame.AutoSize = true;
            this.NameOfGame.Font = new System.Drawing.Font("Comfortaa", 16F, System.Drawing.FontStyle.Bold);
            this.NameOfGame.ForeColor = System.Drawing.Color.Red;
            this.NameOfGame.Location = new System.Drawing.Point(107, 8);
            this.NameOfGame.Name = "NameOfGame";
            this.NameOfGame.Size = new System.Drawing.Size(113, 27);
            this.NameOfGame.TabIndex = 7;
            this.NameOfGame.Text = "Лотерея";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(8, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 27);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PickUpButton
            // 
            this.PickUpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PickUpButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.PickUpButton.Location = new System.Drawing.Point(3, 257);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(320, 25);
            this.PickUpButton.TabIndex = 2;
            this.PickUpButton.Text = "Забрать";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Visible = false;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.BuyTicketButton.Location = new System.Drawing.Point(107, 78);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(106, 26);
            this.BuyTicketButton.TabIndex = 1;
            this.BuyTicketButton.Text = "Купить билет";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.Visible = false;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.StartGame);
            this.groupBox1.Controls.Add(this.FAQButton);
            this.groupBox1.Controls.Add(this.Bu12);
            this.groupBox1.Controls.Add(this.Bu21);
            this.groupBox1.Controls.Add(this.Bu22);
            this.groupBox1.Controls.Add(this.Bu11);
            this.groupBox1.Location = new System.Drawing.Point(100, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CreditButton
            // 
            this.CreditButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.CreditButton.Location = new System.Drawing.Point(100, 213);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(120, 38);
            this.CreditButton.TabIndex = 11;
            this.CreditButton.Text = "Взять кредит";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Visible = false;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(7, 88);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 26);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.StartGame.Location = new System.Drawing.Point(7, 19);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(106, 26);
            this.StartGame.TabIndex = 3;
            this.StartGame.Text = "Играть";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // FAQButton
            // 
            this.FAQButton.Font = new System.Drawing.Font("Comfortaa", 10F, System.Drawing.FontStyle.Bold);
            this.FAQButton.Location = new System.Drawing.Point(7, 51);
            this.FAQButton.Name = "FAQButton";
            this.FAQButton.Size = new System.Drawing.Size(106, 26);
            this.FAQButton.TabIndex = 4;
            this.FAQButton.Text = "FAQ";
            this.FAQButton.UseVisualStyleBackColor = true;
            // 
            // Bu12
            // 
            this.Bu12.Enabled = false;
            this.Bu12.Location = new System.Drawing.Point(63, 10);
            this.Bu12.Name = "Bu12";
            this.Bu12.Size = new System.Drawing.Size(50, 50);
            this.Bu12.TabIndex = 1;
            this.Bu12.UseVisualStyleBackColor = true;
            this.Bu12.Visible = false;
            this.Bu12.Click += new System.EventHandler(this.Bu11_Click);
            // 
            // Bu21
            // 
            this.Bu21.Enabled = false;
            this.Bu21.Location = new System.Drawing.Point(7, 61);
            this.Bu21.Name = "Bu21";
            this.Bu21.Size = new System.Drawing.Size(50, 50);
            this.Bu21.TabIndex = 2;
            this.Bu21.UseVisualStyleBackColor = true;
            this.Bu21.Visible = false;
            this.Bu21.Click += new System.EventHandler(this.Bu11_Click);
            // 
            // Bu22
            // 
            this.Bu22.Enabled = false;
            this.Bu22.Location = new System.Drawing.Point(63, 61);
            this.Bu22.Name = "Bu22";
            this.Bu22.Size = new System.Drawing.Size(50, 50);
            this.Bu22.TabIndex = 3;
            this.Bu22.UseVisualStyleBackColor = true;
            this.Bu22.Visible = false;
            this.Bu22.Click += new System.EventHandler(this.Bu11_Click);
            // 
            // Bu11
            // 
            this.Bu11.Enabled = false;
            this.Bu11.Location = new System.Drawing.Point(7, 10);
            this.Bu11.Name = "Bu11";
            this.Bu11.Size = new System.Drawing.Size(50, 50);
            this.Bu11.TabIndex = 0;
            this.Bu11.UseVisualStyleBackColor = true;
            this.Bu11.Visible = false;
            this.Bu11.Click += new System.EventHandler(this.Bu11_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лотерея 2х2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bu22;
        private System.Windows.Forms.Button Bu21;
        private System.Windows.Forms.Button Bu12;
        private System.Windows.Forms.Button Bu11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FAQButton;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label NameOfGame;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.CheckBox ControlGame;
        private System.Windows.Forms.Button CreditButton;
    }
}

