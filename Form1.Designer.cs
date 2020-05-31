namespace Sender
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmsbn = new System.Windows.Forms.TextBox();
            this.tbcmnd = new System.Windows.Forms.TextBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.RichTextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HoTen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DiaChi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Benh Nhan";
            // 
            // tbmsbn
            // 
            this.tbmsbn.Location = new System.Drawing.Point(232, 83);
            this.tbmsbn.Name = "tbmsbn";
            this.tbmsbn.Size = new System.Drawing.Size(286, 20);
            this.tbmsbn.TabIndex = 5;
            // 
            // tbcmnd
            // 
            this.tbcmnd.Location = new System.Drawing.Point(232, 129);
            this.tbcmnd.Name = "tbcmnd";
            this.tbcmnd.Size = new System.Drawing.Size(286, 20);
            this.tbcmnd.TabIndex = 6;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(232, 166);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(286, 20);
            this.tbhoten.TabIndex = 7;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(232, 218);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(286, 96);
            this.tbdiachi.TabIndex = 8;
            this.tbdiachi.Text = "";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(318, 348);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(128, 32);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.Btnluu_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbcmnd);
            this.Controls.Add(this.tbmsbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmsbn;
        private System.Windows.Forms.TextBox tbcmnd;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.RichTextBox tbdiachi;
        private System.Windows.Forms.Button btnluu;
    }
}

