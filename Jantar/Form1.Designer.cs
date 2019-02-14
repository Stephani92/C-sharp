namespace Jantar
{
    partial class Form1
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.TabDinner = new System.Windows.Forms.TabPage();
            this.tabBirth = new System.Windows.Forms.TabPage();
            this.TxBoxCostDinner = new System.Windows.Forms.TextBox();
            this.cBoxHealthy = new System.Windows.Forms.CheckBox();
            this.cBoxFancy = new System.Windows.Forms.CheckBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txBoxCakeWriting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBoxCostBirth = new System.Windows.Forms.TextBox();
            this.cBoxHealthyCake = new System.Windows.Forms.CheckBox();
            this.cBoxFancyCake = new System.Windows.Forms.CheckBox();
            this.LblCostBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Tab.SuspendLayout();
            this.TabDinner.SuspendLayout();
            this.tabBirth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabDinner);
            this.Tab.Controls.Add(this.tabBirth);
            this.Tab.Location = new System.Drawing.Point(0, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(448, 325);
            this.Tab.TabIndex = 0;
            // 
            // TabDinner
            // 
            this.TabDinner.Controls.Add(this.TxBoxCostDinner);
            this.TabDinner.Controls.Add(this.cBoxHealthy);
            this.TabDinner.Controls.Add(this.cBoxFancy);
            this.TabDinner.Controls.Add(this.LblCost);
            this.TabDinner.Controls.Add(this.label5);
            this.TabDinner.Controls.Add(this.numericUpDown2);
            this.TabDinner.Location = new System.Drawing.Point(4, 25);
            this.TabDinner.Name = "TabDinner";
            this.TabDinner.Padding = new System.Windows.Forms.Padding(3);
            this.TabDinner.Size = new System.Drawing.Size(440, 296);
            this.TabDinner.TabIndex = 0;
            this.TabDinner.Text = "Dinner";
            this.TabDinner.UseVisualStyleBackColor = true;
            // 
            // tabBirth
            // 
            this.tabBirth.Controls.Add(this.txBoxCakeWriting);
            this.tabBirth.Controls.Add(this.label2);
            this.tabBirth.Controls.Add(this.txBoxCostBirth);
            this.tabBirth.Controls.Add(this.cBoxHealthyCake);
            this.tabBirth.Controls.Add(this.cBoxFancyCake);
            this.tabBirth.Controls.Add(this.LblCostBirth);
            this.tabBirth.Controls.Add(this.label1);
            this.tabBirth.Controls.Add(this.numericUpDown1);
            this.tabBirth.Location = new System.Drawing.Point(4, 25);
            this.tabBirth.Name = "tabBirth";
            this.tabBirth.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirth.Size = new System.Drawing.Size(440, 296);
            this.tabBirth.TabIndex = 1;
            this.tabBirth.Text = "Birth";
            this.tabBirth.UseVisualStyleBackColor = true;
            // 
            // TxBoxCostDinner
            // 
            this.TxBoxCostDinner.Enabled = false;
            this.TxBoxCostDinner.Location = new System.Drawing.Point(185, 226);
            this.TxBoxCostDinner.Name = "TxBoxCostDinner";
            this.TxBoxCostDinner.Size = new System.Drawing.Size(100, 22);
            this.TxBoxCostDinner.TabIndex = 20;
            // 
            // cBoxHealthy
            // 
            this.cBoxHealthy.AutoSize = true;
            this.cBoxHealthy.Location = new System.Drawing.Point(172, 153);
            this.cBoxHealthy.Name = "cBoxHealthy";
            this.cBoxHealthy.Size = new System.Drawing.Size(102, 21);
            this.cBoxHealthy.TabIndex = 19;
            this.cBoxHealthy.Text = "Healthy Opt";
            this.cBoxHealthy.UseVisualStyleBackColor = true;
            this.cBoxHealthy.CheckedChanged += new System.EventHandler(this.cBoxHealthy_CheckedChanged);
            // 
            // cBoxFancy
            // 
            this.cBoxFancy.AutoSize = true;
            this.cBoxFancy.Location = new System.Drawing.Point(172, 110);
            this.cBoxFancy.Name = "cBoxFancy";
            this.cBoxFancy.Size = new System.Drawing.Size(138, 21);
            this.cBoxFancy.TabIndex = 18;
            this.cBoxFancy.Text = "Fancy Decoration";
            this.cBoxFancy.UseVisualStyleBackColor = true;
            this.cBoxFancy.CheckedChanged += new System.EventHandler(this.cBoxFancy_CheckedChanged);
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(127, 231);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(40, 17);
            this.LblCost.TabIndex = 17;
            this.LblCost.Text = "Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of People";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(235, 46);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txBoxCakeWriting
            // 
            this.txBoxCakeWriting.Location = new System.Drawing.Point(89, 169);
            this.txBoxCakeWriting.Name = "txBoxCakeWriting";
            this.txBoxCakeWriting.Size = new System.Drawing.Size(266, 22);
            this.txBoxCakeWriting.TabIndex = 16;
            this.txBoxCakeWriting.TextChanged += new System.EventHandler(this.txBoxCakeWriting_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cake Writing:";
            // 
            // txBoxCostBirth
            // 
            this.txBoxCostBirth.Enabled = false;
            this.txBoxCostBirth.Location = new System.Drawing.Point(211, 228);
            this.txBoxCostBirth.Name = "txBoxCostBirth";
            this.txBoxCostBirth.Size = new System.Drawing.Size(100, 22);
            this.txBoxCostBirth.TabIndex = 14;
            // 
            // cBoxHealthyCake
            // 
            this.cBoxHealthyCake.AutoSize = true;
            this.cBoxHealthyCake.Location = new System.Drawing.Point(253, 92);
            this.cBoxHealthyCake.Name = "cBoxHealthyCake";
            this.cBoxHealthyCake.Size = new System.Drawing.Size(102, 21);
            this.cBoxHealthyCake.TabIndex = 13;
            this.cBoxHealthyCake.Text = "Healthy Opt";
            this.cBoxHealthyCake.UseVisualStyleBackColor = true;
            this.cBoxHealthyCake.CheckedChanged += new System.EventHandler(this.cBoxHealthyCake_CheckedChanged);
            // 
            // cBoxFancyCake
            // 
            this.cBoxFancyCake.AutoSize = true;
            this.cBoxFancyCake.Location = new System.Drawing.Point(89, 92);
            this.cBoxFancyCake.Name = "cBoxFancyCake";
            this.cBoxFancyCake.Size = new System.Drawing.Size(138, 21);
            this.cBoxFancyCake.TabIndex = 12;
            this.cBoxFancyCake.Text = "Fancy Decoration";
            this.cBoxFancyCake.UseVisualStyleBackColor = true;
            this.cBoxFancyCake.CheckedChanged += new System.EventHandler(this.cBoxFancyCake_CheckedChanged);
            // 
            // LblCostBirth
            // 
            this.LblCostBirth.AutoSize = true;
            this.LblCostBirth.Location = new System.Drawing.Point(127, 231);
            this.LblCostBirth.Name = "LblCostBirth";
            this.LblCostBirth.Size = new System.Drawing.Size(73, 17);
            this.LblCostBirth.TabIndex = 11;
            this.LblCostBirth.Text = "Cost Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(235, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 343);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tab.ResumeLayout(false);
            this.TabDinner.ResumeLayout(false);
            this.TabDinner.PerformLayout();
            this.tabBirth.ResumeLayout(false);
            this.tabBirth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TabDinner;
        private System.Windows.Forms.TextBox TxBoxCostDinner;
        private System.Windows.Forms.CheckBox cBoxHealthy;
        private System.Windows.Forms.CheckBox cBoxFancy;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TabPage tabBirth;
        private System.Windows.Forms.TextBox txBoxCakeWriting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBoxCostBirth;
        private System.Windows.Forms.CheckBox cBoxHealthyCake;
        private System.Windows.Forms.CheckBox cBoxFancyCake;
        private System.Windows.Forms.Label LblCostBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

