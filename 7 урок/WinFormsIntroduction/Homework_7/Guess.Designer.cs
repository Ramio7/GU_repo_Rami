namespace Homework_7
{
    partial class Guess
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
            this.tbx_Guess_UserAnswer = new System.Windows.Forms.TextBox();
            this.lb_Guess_toUser_1 = new System.Windows.Forms.Label();
            this.lb_Guess_Title = new System.Windows.Forms.Label();
            this.lb_Guess_toUser_2 = new System.Windows.Forms.Label();
            this.lb_Guess_Counter = new System.Windows.Forms.Label();
            this.btn_Send_Answer = new System.Windows.Forms.Button();
            this.lb_Guess_Result = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Guess_UserAnswer
            // 
            this.tbx_Guess_UserAnswer.Location = new System.Drawing.Point(265, 337);
            this.tbx_Guess_UserAnswer.Name = "tbx_Guess_UserAnswer";
            this.tbx_Guess_UserAnswer.Size = new System.Drawing.Size(492, 23);
            this.tbx_Guess_UserAnswer.TabIndex = 5;
            this.tbx_Guess_UserAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Guess_UserAnswer_KeyDown);
            // 
            // lb_Guess_toUser_1
            // 
            this.lb_Guess_toUser_1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Guess_toUser_1.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Guess_toUser_1.Location = new System.Drawing.Point(0, 94);
            this.lb_Guess_toUser_1.Name = "lb_Guess_toUser_1";
            this.lb_Guess_toUser_1.Size = new System.Drawing.Size(1008, 140);
            this.lb_Guess_toUser_1.TabIndex = 10;
            this.lb_Guess_toUser_1.Text = "Используйте интуицию или же холодный расчёт для того, чтобы угадать загаданное ко" +
    "мпьютером число от 1 до 100!";
            this.lb_Guess_toUser_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Guess_Title
            // 
            this.lb_Guess_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Guess_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Guess_Title.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Guess_Title.Location = new System.Drawing.Point(0, 0);
            this.lb_Guess_Title.Name = "lb_Guess_Title";
            this.lb_Guess_Title.Size = new System.Drawing.Size(1008, 37);
            this.lb_Guess_Title.TabIndex = 9;
            this.lb_Guess_Title.Text = "Угадай число!";
            this.lb_Guess_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Guess_toUser_2
            // 
            this.lb_Guess_toUser_2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Guess_toUser_2.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Guess_toUser_2.Location = new System.Drawing.Point(0, 250);
            this.lb_Guess_toUser_2.Name = "lb_Guess_toUser_2";
            this.lb_Guess_toUser_2.Size = new System.Drawing.Size(1008, 84);
            this.lb_Guess_toUser_2.TabIndex = 11;
            this.lb_Guess_toUser_2.Text = "Введите свою догадку:";
            this.lb_Guess_toUser_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Guess_Counter
            // 
            this.lb_Guess_Counter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Guess_Counter.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Guess_Counter.Location = new System.Drawing.Point(0, 464);
            this.lb_Guess_Counter.Name = "lb_Guess_Counter";
            this.lb_Guess_Counter.Size = new System.Drawing.Size(1008, 84);
            this.lb_Guess_Counter.TabIndex = 12;
            this.lb_Guess_Counter.Text = "Вы ещё не предпринимали попыток угадать.";
            this.lb_Guess_Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Send_Answer
            // 
            this.btn_Send_Answer.BackColor = System.Drawing.Color.Gold;
            this.btn_Send_Answer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Send_Answer.Location = new System.Drawing.Point(353, 410);
            this.btn_Send_Answer.Name = "btn_Send_Answer";
            this.btn_Send_Answer.Size = new System.Drawing.Size(319, 58);
            this.btn_Send_Answer.TabIndex = 13;
            this.btn_Send_Answer.Text = "Проверить ответ";
            this.btn_Send_Answer.UseVisualStyleBackColor = false;
            this.btn_Send_Answer.Click += new System.EventHandler(this.btn_Send_Answer_Click);
            // 
            // lb_Guess_Result
            // 
            this.lb_Guess_Result.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Guess_Result.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Guess_Result.Location = new System.Drawing.Point(0, 521);
            this.lb_Guess_Result.Name = "lb_Guess_Result";
            this.lb_Guess_Result.Size = new System.Drawing.Size(1008, 84);
            this.lb_Guess_Result.TabIndex = 14;
            this.lb_Guess_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(782, 608);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(214, 109);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lb_Guess_Result);
            this.Controls.Add(this.btn_Send_Answer);
            this.Controls.Add(this.lb_Guess_Counter);
            this.Controls.Add(this.lb_Guess_toUser_2);
            this.Controls.Add(this.lb_Guess_toUser_1);
            this.Controls.Add(this.lb_Guess_Title);
            this.Controls.Add(this.tbx_Guess_UserAnswer);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Guess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbx_Guess_UserAnswer;
        private Label lb_Guess_toUser_1;
        private Label lb_Guess_Title;
        private Label lb_Guess_toUser_2;
        private Label lb_Guess_Counter;
        private Button btn_Send_Answer;
        private Label lb_Guess_Result;
        private Button btn_Exit;
    }
}