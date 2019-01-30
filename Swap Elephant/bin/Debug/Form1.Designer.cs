namespace Swap_Elephant
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
            this.bntLloyd = new System.Windows.Forms.Button();
            this.bntLucinda = new System.Windows.Forms.Button();
            this.bntSwap = new System.Windows.Forms.Button();
            this.bntTellMe = new System.Windows.Forms.Button();
            this.bntSpeakTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntLloyd
            // 
            this.bntLloyd.Location = new System.Drawing.Point(129, 12);
            this.bntLloyd.Name = "bntLloyd";
            this.bntLloyd.Size = new System.Drawing.Size(114, 42);
            this.bntLloyd.TabIndex = 0;
            this.bntLloyd.Text = "Lloyd";
            this.bntLloyd.UseVisualStyleBackColor = true;
            this.bntLloyd.Click += new System.EventHandler(this.bntLloyd_Click);
            // 
            // bntLucinda
            // 
            this.bntLucinda.Location = new System.Drawing.Point(12, 12);
            this.bntLucinda.Name = "bntLucinda";
            this.bntLucinda.Size = new System.Drawing.Size(108, 42);
            this.bntLucinda.TabIndex = 1;
            this.bntLucinda.Text = "Lucinda";
            this.bntLucinda.UseVisualStyleBackColor = true;
            this.bntLucinda.Click += new System.EventHandler(this.bntLucinda_Click);
            // 
            // bntSwap
            // 
            this.bntSwap.Location = new System.Drawing.Point(60, 71);
            this.bntSwap.Name = "bntSwap";
            this.bntSwap.Size = new System.Drawing.Size(131, 42);
            this.bntSwap.TabIndex = 2;
            this.bntSwap.Text = "Swap";
            this.bntSwap.UseVisualStyleBackColor = true;
            this.bntSwap.Click += new System.EventHandler(this.bntSwap_Click);
            // 
            // bntTellMe
            // 
            this.bntTellMe.Location = new System.Drawing.Point(60, 138);
            this.bntTellMe.Name = "bntTellMe";
            this.bntTellMe.Size = new System.Drawing.Size(131, 42);
            this.bntTellMe.TabIndex = 3;
            this.bntTellMe.Text = "Tell Me";
            this.bntTellMe.UseVisualStyleBackColor = true;
            this.bntTellMe.Click += new System.EventHandler(this.bntTellMe_Click);
            // 
            // bntSpeakTo
            // 
            this.bntSpeakTo.Location = new System.Drawing.Point(60, 207);
            this.bntSpeakTo.Name = "bntSpeakTo";
            this.bntSpeakTo.Size = new System.Drawing.Size(131, 42);
            this.bntSpeakTo.TabIndex = 4;
            this.bntSpeakTo.Text = "Speak To";
            this.bntSpeakTo.UseVisualStyleBackColor = true;
            this.bntSpeakTo.Click += new System.EventHandler(this.bntSpeakTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 284);
            this.Controls.Add(this.bntSpeakTo);
            this.Controls.Add(this.bntTellMe);
            this.Controls.Add(this.bntSwap);
            this.Controls.Add(this.bntLucinda);
            this.Controls.Add(this.bntLloyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntLloyd;
        private System.Windows.Forms.Button bntLucinda;
        private System.Windows.Forms.Button bntSwap;
        private System.Windows.Forms.Button bntTellMe;
        private System.Windows.Forms.Button bntSpeakTo;
    }
}

