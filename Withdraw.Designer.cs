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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.wBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.wConPin = new System.Windows.Forms.TextBox();
            this.wPin = new System.Windows.Forms.TextBox();
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
            this.withdrawPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.panel1);
            this.withdrawPanel.Controls.Add(this.wBtn);
            this.withdrawPanel.Controls.Add(this.label8);
            this.withdrawPanel.Controls.Add(this.wConPin);
            this.withdrawPanel.Controls.Add(this.wPin);
            this.withdrawPanel.Controls.Add(this.label7);
            this.withdrawPanel.Controls.Add(this.wAmountText);
            this.withdrawPanel.Controls.Add(this.label6);
            this.withdrawPanel.Controls.Add(this.balanceWith);
            this.withdrawPanel.Controls.Add(this.label5);
            this.withdrawPanel.Controls.Add(this.panel4);
            this.withdrawPanel.Location = new System.Drawing.Point(0, 0);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(920, 512);
            this.withdrawPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 53);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "WITHDRAW";
            // 
            // wBtn
            // 
            this.wBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.wBtn.FlatAppearance.BorderSize = 0;
            this.wBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wBtn.Location = new System.Drawing.Point(437, 403);
            this.wBtn.Name = "wBtn";
            this.wBtn.Size = new System.Drawing.Size(169, 36);
            this.wBtn.TabIndex = 16;
            this.wBtn.Text = "WITHDRAW";
            this.wBtn.UseVisualStyleBackColor = false;
            this.wBtn.Click += new System.EventHandler(this.wBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(167, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 45);
            this.label8.TabIndex = 15;
            this.label8.Text = "Confirm Pin:";
            // 
            // wConPin
            // 
            this.wConPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wConPin.Location = new System.Drawing.Point(437, 333);
            this.wConPin.Multiline = true;
            this.wConPin.Name = "wConPin";
            this.wConPin.PasswordChar = '*';
            this.wConPin.Size = new System.Drawing.Size(169, 26);
            this.wConPin.TabIndex = 14;
            // 
            // wPin
            // 
            this.wPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wPin.Location = new System.Drawing.Point(437, 278);
            this.wPin.Multiline = true;
            this.wPin.Name = "wPin";
            this.wPin.PasswordChar = '*';
            this.wPin.Size = new System.Drawing.Size(169, 26);
            this.wPin.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(170, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 45);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pin:";
            // 
            // wAmountText
            // 
            this.wAmountText.Cursor = System.Windows.Forms.Cursors.Default;
            this.wAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wAmountText.Location = new System.Drawing.Point(437, 224);
            this.wAmountText.MaxLength = 7;
            this.wAmountText.Multiline = true;
            this.wAmountText.Name = "wAmountText";
            this.wAmountText.Size = new System.Drawing.Size(169, 26);
            this.wAmountText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(167, 210);
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
            this.balanceWith.Location = new System.Drawing.Point(163, 110);
            this.balanceWith.Name = "balanceWith";
            this.balanceWith.Size = new System.Drawing.Size(0, 65);
            this.balanceWith.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(170, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your Balance:";
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
            this.button8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button8.Location = new System.Drawing.Point(3, 134);
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
            this.button5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(0, 175);
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
            this.button6.ForeColor = System.Drawing.Color.DeepSkyBlue;
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
            this.panel5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 118);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(0, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(919, 509);
            this.Controls.Add(this.withdrawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        private System.Windows.Forms.Panel withdrawPanel;
        /// </summary>
        private System.Windows.Forms.Button wBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wConPin;
        private System.Windows.Forms.TextBox wPin;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}