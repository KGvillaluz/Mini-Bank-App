namespace BankManagement
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.wBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.wPin = new System.Windows.Forms.TextBox();
            this.wAccNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wAmountText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.balanceWith = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.wBtn);
            this.withdrawPanel.Controls.Add(this.label8);
            this.withdrawPanel.Controls.Add(this.wPin);
            this.withdrawPanel.Controls.Add(this.wAccNum);
            this.withdrawPanel.Controls.Add(this.label7);
            this.withdrawPanel.Controls.Add(this.wAmountText);
            this.withdrawPanel.Controls.Add(this.label6);
            this.withdrawPanel.Controls.Add(this.balanceWith);
            this.withdrawPanel.Controls.Add(this.label5);
            this.withdrawPanel.Controls.Add(this.panel4);
            this.withdrawPanel.Controls.Add(this.flowLayoutPanel2);
            this.withdrawPanel.Location = new System.Drawing.Point(0, 0);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(953, 512);
            this.withdrawPanel.TabIndex = 9;
            this.withdrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.withdrawPanel_Paint);
            // 
            // wBtn
            // 
            this.wBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wBtn.ForeColor = System.Drawing.Color.Black;
            this.wBtn.Location = new System.Drawing.Point(410, 386);
            this.wBtn.Name = "wBtn";
            this.wBtn.Size = new System.Drawing.Size(149, 36);
            this.wBtn.TabIndex = 16;
            this.wBtn.Text = "WITHDRAW";
            this.wBtn.UseVisualStyleBackColor = true;
            this.wBtn.Click += new System.EventHandler(this.wBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(166, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 45);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pin:";
            // 
            // wPin
            // 
            this.wPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wPin.Location = new System.Drawing.Point(411, 312);
            this.wPin.Multiline = true;
            this.wPin.Name = "wPin";
            this.wPin.Size = new System.Drawing.Size(149, 26);
            this.wPin.TabIndex = 14;
            // 
            // wAccNum
            // 
            this.wAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wAccNum.Location = new System.Drawing.Point(411, 262);
            this.wAccNum.Multiline = true;
            this.wAccNum.Name = "wAccNum";
            this.wAccNum.Size = new System.Drawing.Size(149, 26);
            this.wAccNum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(169, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 45);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account No.";
            // 
            // wAmountText
            // 
            this.wAmountText.Cursor = System.Windows.Forms.Cursors.Default;
            this.wAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wAmountText.Location = new System.Drawing.Point(410, 213);
            this.wAmountText.MaxLength = 7;
            this.wAmountText.Multiline = true;
            this.wAmountText.Name = "wAmountText";
            this.wAmountText.Size = new System.Drawing.Size(149, 26);
            this.wAmountText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(166, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Amount:";
            // 
            // balanceWith
            // 
            this.balanceWith.AutoSize = true;
            this.balanceWith.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceWith.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceWith.Location = new System.Drawing.Point(373, 106);
            this.balanceWith.Name = "balanceWith";
            this.balanceWith.Size = new System.Drawing.Size(0, 65);
            this.balanceWith.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(167, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 59);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balance";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 512);
            this.panel4.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(0, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 35);
            this.button8.TabIndex = 5;
            this.button8.Text = "DASHBOARD";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(-1, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "DEPOSIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(-1, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "SIGN OUT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 118);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(52, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(161, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(792, 92);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.MaximumSize = new System.Drawing.Size(0, 50);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(271, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "WITHDRAW";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(952, 509);
            this.Controls.Add(this.withdrawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Button wBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wPin;
        private System.Windows.Forms.TextBox wAccNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wAmountText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label balanceWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
    }
}