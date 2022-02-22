namespace Homework_7
{
    partial class Doubler
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Increment = new System.Windows.Forms.Button();
            this.lb_Doubler_Target = new System.Windows.Forms.Label();
            this.lb_Doubler_Current = new System.Windows.Forms.Label();
            this.lb_Doubler_ToUser = new System.Windows.Forms.Label();
            this.lb_Doubler_Title = new System.Windows.Forms.Label();
            this.lb_Doubler_Counter = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Doubler
            // 
            this.btn_Doubler.BackColor = System.Drawing.Color.Gold;
            this.btn_Doubler.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Doubler.Location = new System.Drawing.Point(698, 264);
            this.btn_Doubler.Name = "btn_Doubler";
            this.btn_Doubler.Size = new System.Drawing.Size(241, 139);
            this.btn_Doubler.TabIndex = 0;
            this.btn_Doubler.Text = "х2";
            this.btn_Doubler.UseVisualStyleBackColor = false;
            this.btn_Doubler.Click += new System.EventHandler(this.btn_Doubler_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Gold;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(84, 264);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(241, 139);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Играть";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Increment
            // 
            this.btn_Increment.BackColor = System.Drawing.Color.Gold;
            this.btn_Increment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Increment.Location = new System.Drawing.Point(397, 264);
            this.btn_Increment.Name = "btn_Increment";
            this.btn_Increment.Size = new System.Drawing.Size(241, 139);
            this.btn_Increment.TabIndex = 2;
            this.btn_Increment.Text = "+1";
            this.btn_Increment.UseVisualStyleBackColor = false;
            this.btn_Increment.Click += new System.EventHandler(this.btn_Increment_Click);
            // 
            // lb_Doubler_Target
            // 
            this.lb_Doubler_Target.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Doubler_Target.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Doubler_Target.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Doubler_Target.Location = new System.Drawing.Point(84, 521);
            this.lb_Doubler_Target.Name = "lb_Doubler_Target";
            this.lb_Doubler_Target.Size = new System.Drawing.Size(370, 39);
            this.lb_Doubler_Target.TabIndex = 4;
            this.lb_Doubler_Target.Text = "Загаданное число:";
            this.lb_Doubler_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Doubler_Current
            // 
            this.lb_Doubler_Current.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Doubler_Current.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Doubler_Current.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Doubler_Current.Location = new System.Drawing.Point(569, 521);
            this.lb_Doubler_Current.Name = "lb_Doubler_Current";
            this.lb_Doubler_Current.Size = new System.Drawing.Size(370, 39);
            this.lb_Doubler_Current.TabIndex = 5;
            this.lb_Doubler_Current.Text = "Текущее число:";
            this.lb_Doubler_Current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Doubler_ToUser
            // 
            this.lb_Doubler_ToUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Doubler_ToUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Doubler_ToUser.Location = new System.Drawing.Point(0, 78);
            this.lb_Doubler_ToUser.Name = "lb_Doubler_ToUser";
            this.lb_Doubler_ToUser.Size = new System.Drawing.Size(1008, 140);
            this.lb_Doubler_ToUser.TabIndex = 8;
            this.lb_Doubler_ToUser.Text = "С помощью операций прибавления к существующему числу единицы и умножения его на д" +
    "ва получите загаданное компьютером число.";
            this.lb_Doubler_ToUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Doubler_Title
            // 
            this.lb_Doubler_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Doubler_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Doubler_Title.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Doubler_Title.Location = new System.Drawing.Point(0, 0);
            this.lb_Doubler_Title.Name = "lb_Doubler_Title";
            this.lb_Doubler_Title.Size = new System.Drawing.Size(1008, 37);
            this.lb_Doubler_Title.TabIndex = 7;
            this.lb_Doubler_Title.Text = "Удвоитель";
            this.lb_Doubler_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Doubler_Counter
            // 
            this.lb_Doubler_Counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Doubler_Counter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Doubler_Counter.ForeColor = System.Drawing.Color.GhostWhite;
            this.lb_Doubler_Counter.Location = new System.Drawing.Point(84, 629);
            this.lb_Doubler_Counter.Name = "lb_Doubler_Counter";
            this.lb_Doubler_Counter.Size = new System.Drawing.Size(402, 39);
            this.lb_Doubler_Counter.TabIndex = 9;
            this.lb_Doubler_Counter.Text = "Вы выполнили операций:";
            this.lb_Doubler_Counter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(725, 598);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(214, 109);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lb_Doubler_Counter);
            this.Controls.Add(this.lb_Doubler_ToUser);
            this.Controls.Add(this.lb_Doubler_Title);
            this.Controls.Add(this.lb_Doubler_Current);
            this.Controls.Add(this.lb_Doubler_Target);
            this.Controls.Add(this.btn_Increment);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Doubler);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Doubler;
        private Button btn_Reset;
        private Button btn_Increment;
        private Label lb_Doubler_Target;
        private Label lb_Doubler_Current;
        private Label lb_Doubler_ToUser;
        private Label lb_Doubler_Title;
        private Label lb_Doubler_Counter;
        private Button btn_Exit;
    }
}