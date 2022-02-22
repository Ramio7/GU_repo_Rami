namespace Homework_7
{
    partial class HW_7_MainMenu
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
            this.btn_Doubler = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Doubler
            // 
            this.btn_Doubler.BackColor = System.Drawing.Color.Gold;
            this.btn_Doubler.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Doubler.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Doubler.FlatAppearance.BorderSize = 20;
            this.btn_Doubler.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Doubler.Location = new System.Drawing.Point(113, 254);
            this.btn_Doubler.Name = "btn_Doubler";
            this.btn_Doubler.Size = new System.Drawing.Size(319, 245);
            this.btn_Doubler.TabIndex = 1;
            this.btn_Doubler.Text = "Удвоитель";
            this.btn_Doubler.UseVisualStyleBackColor = false;
            this.btn_Doubler.Click += new System.EventHandler(this.btn_Doubler_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(782, 608);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(214, 109);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Guess
            // 
            this.btn_Guess.BackColor = System.Drawing.Color.Gold;
            this.btn_Guess.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Guess.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Guess.FlatAppearance.BorderSize = 20;
            this.btn_Guess.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guess.Location = new System.Drawing.Point(592, 254);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(319, 245);
            this.btn_Guess.TabIndex = 4;
            this.btn_Guess.Text = "Угадай число";
            this.btn_Guess.UseVisualStyleBackColor = false;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добро пожаловать в учебное задание студента Рамиля Рахимкулова!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(0, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1008, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пожалуйста, выберите приложение из списка ниже:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HW_7_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Doubler);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "HW_7_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_Doubler;
        private Button btn_Exit;
        private Button btn_Guess;
        private Label label1;
        private Label label2;
    }
}