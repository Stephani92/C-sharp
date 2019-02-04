namespace Game_Corridas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinBet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumUpDownDog = new System.Windows.Forms.NumericUpDown();
            this.lblNumeDog = new System.Windows.Forms.Label();
            this.bntBet = new System.Windows.Forms.Button();
            this.numUpDoenBet = new System.Windows.Forms.NumericUpDown();
            this.lblNameBet = new System.Windows.Forms.Label();
            this.rbntAl = new System.Windows.Forms.RadioButton();
            this.rbtnBob = new System.Windows.Forms.RadioButton();
            this.rdioJoe = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoenBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // bntRun
            // 
            this.bntRun.Location = new System.Drawing.Point(555, 133);
            this.bntRun.Name = "bntRun";
            this.bntRun.Size = new System.Drawing.Size(75, 23);
            this.bntRun.TabIndex = 0;
            this.bntRun.Text = "Run";
            this.bntRun.UseVisualStyleBackColor = true;
            this.bntRun.Click += new System.EventHandler(this.bntRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntClear);
            this.groupBox1.Controls.Add(this.lblfinal);
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Controls.Add(this.lblAl);
            this.groupBox1.Controls.Add(this.lblBob);
            this.groupBox1.Controls.Add(this.lblJoe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMinBet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumUpDownDog);
            this.groupBox1.Controls.Add(this.lblNumeDog);
            this.groupBox1.Controls.Add(this.bntBet);
            this.groupBox1.Controls.Add(this.numUpDoenBet);
            this.groupBox1.Controls.Add(this.lblNameBet);
            this.groupBox1.Controls.Add(this.rbntAl);
            this.groupBox1.Controls.Add(this.rbtnBob);
            this.groupBox1.Controls.Add(this.rdioJoe);
            this.groupBox1.Controls.Add(this.bntRun);
            this.groupBox1.Location = new System.Drawing.Point(2, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // lblMinBet
            // 
            this.lblMinBet.AutoSize = true;
            this.lblMinBet.Location = new System.Drawing.Point(38, 84);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(39, 17);
            this.lblMinBet.TabIndex = 10;
            this.lblMinBet.Text = "teste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum bet:";
            // 
            // NumUpDownDog
            // 
            this.NumUpDownDog.Location = new System.Drawing.Point(270, 135);
            this.NumUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownDog.Name = "NumUpDownDog";
            this.NumUpDownDog.Size = new System.Drawing.Size(53, 22);
            this.NumUpDownDog.TabIndex = 8;
            this.NumUpDownDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumeDog
            // 
            this.lblNumeDog.AutoSize = true;
            this.lblNumeDog.Location = new System.Drawing.Point(147, 139);
            this.lblNumeDog.Name = "lblNumeDog";
            this.lblNumeDog.Size = new System.Drawing.Size(117, 17);
            this.lblNumeDog.TabIndex = 7;
            this.lblNumeDog.Text = "Num do cachorro";
            // 
            // bntBet
            // 
            this.bntBet.Location = new System.Drawing.Point(366, 134);
            this.bntBet.Name = "bntBet";
            this.bntBet.Size = new System.Drawing.Size(75, 23);
            this.bntBet.TabIndex = 6;
            this.bntBet.Text = "Bet";
            this.bntBet.UseVisualStyleBackColor = true;
            this.bntBet.Click += new System.EventHandler(this.bntBet_Click);
            // 
            // numUpDoenBet
            // 
            this.numUpDoenBet.Location = new System.Drawing.Point(76, 134);
            this.numUpDoenBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDoenBet.Name = "numUpDoenBet";
            this.numUpDoenBet.Size = new System.Drawing.Size(53, 22);
            this.numUpDoenBet.TabIndex = 5;
            this.numUpDoenBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblNameBet
            // 
            this.lblNameBet.AutoSize = true;
            this.lblNameBet.Location = new System.Drawing.Point(10, 136);
            this.lblNameBet.Name = "lblNameBet";
            this.lblNameBet.Size = new System.Drawing.Size(0, 17);
            this.lblNameBet.TabIndex = 4;
            // 
            // rbntAl
            // 
            this.rbntAl.AutoSize = true;
            this.rbntAl.Location = new System.Drawing.Point(157, 95);
            this.rbntAl.Name = "rbntAl";
            this.rbntAl.Size = new System.Drawing.Size(14, 13);
            this.rbntAl.TabIndex = 3;
            this.rbntAl.TabStop = true;
            this.rbntAl.UseVisualStyleBackColor = true;
            this.rbntAl.CheckedChanged += new System.EventHandler(this.rbntAl_CheckedChanged);
            // 
            // rbtnBob
            // 
            this.rbtnBob.AutoSize = true;
            this.rbtnBob.Location = new System.Drawing.Point(157, 57);
            this.rbtnBob.Name = "rbtnBob";
            this.rbtnBob.Size = new System.Drawing.Size(14, 13);
            this.rbtnBob.TabIndex = 2;
            this.rbtnBob.TabStop = true;
            this.rbtnBob.UseVisualStyleBackColor = true;
            this.rbtnBob.CheckedChanged += new System.EventHandler(this.rbtnBob_CheckedChanged);
            // 
            // rdioJoe
            // 
            this.rdioJoe.AutoSize = true;
            this.rdioJoe.Location = new System.Drawing.Point(157, 21);
            this.rdioJoe.Name = "rdioJoe";
            this.rdioJoe.Size = new System.Drawing.Size(14, 13);
            this.rdioJoe.TabIndex = 1;
            this.rdioJoe.TabStop = true;
            this.rdioJoe.UseVisualStyleBackColor = true;
            this.rdioJoe.CheckedChanged += new System.EventHandler(this.rdioJoe_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 216);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // lblJoe
            // 
            this.lblJoe.AutoSize = true;
            this.lblJoe.Location = new System.Drawing.Point(543, 21);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(46, 17);
            this.lblJoe.TabIndex = 15;
            this.lblJoe.Text = "label3";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(543, 57);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(46, 17);
            this.lblBob.TabIndex = 16;
            this.lblBob.Text = "label3";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(543, 93);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(46, 17);
            this.lblAl.TabIndex = 17;
            this.lblAl.Text = "label3";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(380, 75);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(46, 17);
            this.lblTest.TabIndex = 18;
            this.lblTest.Text = "label3";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(380, 37);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(46, 17);
            this.lblfinal.TabIndex = 19;
            this.lblfinal.Text = "label3";
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(680, 134);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 20;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoenBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMinBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumUpDownDog;
        private System.Windows.Forms.Label lblNumeDog;
        private System.Windows.Forms.Button bntBet;
        private System.Windows.Forms.NumericUpDown numUpDoenBet;
        private System.Windows.Forms.Label lblNameBet;
        private System.Windows.Forms.RadioButton rbntAl;
        private System.Windows.Forms.RadioButton rbtnBob;
        private System.Windows.Forms.RadioButton rdioJoe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJoe;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Button bntClear;
    }
}

