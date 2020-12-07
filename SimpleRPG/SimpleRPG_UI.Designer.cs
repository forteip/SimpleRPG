namespace SimpleRPG
{
    partial class SimpleRPG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblEXP = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "EXP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Level:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(41, 655);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(54, 15);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP value";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(41, 670);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(65, 15);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level value";
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Location = new System.Drawing.Point(41, 685);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(58, 15);
            this.lblEXP.TabIndex = 1;
            this.lblEXP.Text = "EXP value";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(41, 700);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(63, 15);
            this.lblGold.TabIndex = 1;
            this.lblGold.Text = "Gold value";
            // 
            // SimpleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 764);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblEXP);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleRPG";
            this.Text = "SimpleRPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.Label lblGold;
    }
}

