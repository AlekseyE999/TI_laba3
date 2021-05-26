namespace GUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.GenKey = new System.Windows.Forms.Button();
            this.GenSig = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 33);
            this.label3.TabIndex = 39;
            this.label3.Text = "Input text";
            // 
            // GenKey
            // 
            this.GenKey.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenKey.Location = new System.Drawing.Point(941, 514);
            this.GenKey.Name = "GenKey";
            this.GenKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenKey.Size = new System.Drawing.Size(276, 45);
            this.GenKey.TabIndex = 38;
            this.GenKey.Text = "Generate key";
            this.GenKey.UseVisualStyleBackColor = true;
            this.GenKey.Click += new System.EventHandler(this.GenKey_Click);
            // 
            // GenSig
            // 
            this.GenSig.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenSig.Location = new System.Drawing.Point(535, 514);
            this.GenSig.Name = "GenSig";
            this.GenSig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenSig.Size = new System.Drawing.Size(276, 45);
            this.GenSig.TabIndex = 37;
            this.GenSig.Text = "Generate signature";
            this.GenSig.UseVisualStyleBackColor = true;
            this.GenSig.Click += new System.EventHandler(this.GenSig_Click);
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.Location = new System.Drawing.Point(113, 514);
            this.Check.Name = "Check";
            this.Check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Check.Size = new System.Drawing.Size(276, 45);
            this.Check.TabIndex = 36;
            this.Check.Text = "Check ";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 72);
            this.label2.TabIndex = 35;
            this.label2.Text = "Digital signature";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "e";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(128, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "d";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(103, 73);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(380, 30);
            this.input.TabIndex = 28;
            // 
            // e
            // 
            this.e.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.Location = new System.Drawing.Point(182, 172);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(991, 30);
            this.e.TabIndex = 40;
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n.Location = new System.Drawing.Point(182, 246);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(991, 30);
            this.n.TabIndex = 41;
            // 
            // d
            // 
            this.d.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d.Location = new System.Drawing.Point(182, 331);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(991, 30);
            this.d.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 33);
            this.label4.TabIndex = 43;
            this.label4.Text = "n";
            // 
            // sig
            // 
            this.sig.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sig.Location = new System.Drawing.Point(182, 415);
            this.sig.Name = "sig";
            this.sig.Size = new System.Drawing.Size(991, 30);
            this.sig.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 607);
            this.Controls.Add(this.sig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.d);
            this.Controls.Add(this.n);
            this.Controls.Add(this.e);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenKey);
            this.Controls.Add(this.GenSig);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenKey;
        private System.Windows.Forms.Button GenSig;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sig;
    }
}

