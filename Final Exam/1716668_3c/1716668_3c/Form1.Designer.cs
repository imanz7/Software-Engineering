
namespace _1716668_3c
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_en = new System.Windows.Forms.Button();
            this.btn_de = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 174);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 250);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(434, 174);
            this.textBox2.TabIndex = 1;
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(144, 453);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(75, 23);
            this.btn_en.TabIndex = 2;
            this.btn_en.Text = "Encrypt";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(312, 453);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(75, 23);
            this.btn_de.TabIndex = 3;
            this.btn_de.Text = "Decrypt";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 507);
            this.Controls.Add(this.btn_de);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button btn_de;
    }
}

