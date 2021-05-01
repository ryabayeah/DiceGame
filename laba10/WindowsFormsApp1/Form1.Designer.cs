
namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PCube1 = new System.Windows.Forms.TextBox();
            this.PCube2 = new System.Windows.Forms.TextBox();
            this.PCube3 = new System.Windows.Forms.TextBox();
            this.CCube1 = new System.Windows.Forms.TextBox();
            this.CCube2 = new System.Windows.Forms.TextBox();
            this.CCube3 = new System.Windows.Forms.TextBox();
            this.RollB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lWinner);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RollB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 228);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(288, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer";
            // 
            // PCube1
            // 
            this.PCube1.Enabled = false;
            this.PCube1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCube1.Location = new System.Drawing.Point(29, 44);
            this.PCube1.Name = "PCube1";
            this.PCube1.Size = new System.Drawing.Size(21, 22);
            this.PCube1.TabIndex = 2;
            // 
            // PCube2
            // 
            this.PCube2.Enabled = false;
            this.PCube2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PCube2.Location = new System.Drawing.Point(56, 44);
            this.PCube2.Name = "PCube2";
            this.PCube2.Size = new System.Drawing.Size(21, 22);
            this.PCube2.TabIndex = 3;
            // 
            // PCube3
            // 
            this.PCube3.Enabled = false;
            this.PCube3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PCube3.Location = new System.Drawing.Point(83, 44);
            this.PCube3.Name = "PCube3";
            this.PCube3.Size = new System.Drawing.Size(21, 22);
            this.PCube3.TabIndex = 4;
            // 
            // CCube1
            // 
            this.CCube1.Enabled = false;
            this.CCube1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CCube1.Location = new System.Drawing.Point(290, 44);
            this.CCube1.Name = "CCube1";
            this.CCube1.Size = new System.Drawing.Size(21, 22);
            this.CCube1.TabIndex = 5;
            // 
            // CCube2
            // 
            this.CCube2.Enabled = false;
            this.CCube2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CCube2.Location = new System.Drawing.Point(317, 44);
            this.CCube2.Name = "CCube2";
            this.CCube2.Size = new System.Drawing.Size(21, 22);
            this.CCube2.TabIndex = 6;
            // 
            // CCube3
            // 
            this.CCube3.Enabled = false;
            this.CCube3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CCube3.Location = new System.Drawing.Point(344, 44);
            this.CCube3.Name = "CCube3";
            this.CCube3.Size = new System.Drawing.Size(21, 22);
            this.CCube3.TabIndex = 7;
            // 
            // RollB
            // 
            this.RollB.BackColor = System.Drawing.SystemColors.Info;
            this.RollB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RollB.FlatAppearance.BorderSize = 0;
            this.RollB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RollB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RollB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RollB.Location = new System.Drawing.Point(142, 129);
            this.RollB.Name = "RollB";
            this.RollB.Size = new System.Drawing.Size(131, 29);
            this.RollB.TabIndex = 8;
            this.RollB.Text = "Roll the dice!";
            this.RollB.UseVisualStyleBackColor = false;
            this.RollB.Click += new System.EventHandler(this.RollB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PCube1);
            this.panel2.Controls.Add(this.CCube3);
            this.panel2.Controls.Add(this.PCube2);
            this.panel2.Controls.Add(this.CCube2);
            this.panel2.Controls.Add(this.PCube3);
            this.panel2.Controls.Add(this.CCube1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 85);
            this.panel2.TabIndex = 9;
            // 
            // lWinner
            // 
            this.lWinner.AutoSize = true;
            this.lWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWinner.Location = new System.Drawing.Point(91, 180);
            this.lWinner.Name = "lWinner";
            this.lWinner.Size = new System.Drawing.Size(0, 24);
            this.lWinner.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dice game";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 252);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hello";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RollB;
        private System.Windows.Forms.TextBox CCube3;
        private System.Windows.Forms.TextBox CCube2;
        private System.Windows.Forms.TextBox CCube1;
        private System.Windows.Forms.TextBox PCube3;
        private System.Windows.Forms.TextBox PCube2;
        private System.Windows.Forms.TextBox PCube1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lWinner;
        private System.Windows.Forms.Label label4;
    }
}

