namespace B3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "a2";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(160, 256);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(75, 23);
            this.btnXemKQ.TabIndex = 1;
            this.btnXemKQ.Text = "Xem KQ";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(205, 40);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 2;
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(205, 111);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 22);
            this.txtA1.TabIndex = 2;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(205, 182);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 22);
            this.txtA2.TabIndex = 2;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(448, 101);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 22);
            this.txtKQ.TabIndex = 2;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(86, 81);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(13, 16);
            this.x.TabIndex = 0;
            this.x.Text = "x";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(205, 75);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox txtX;
    }
}

