
namespace _1920_2c
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
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(82, 85);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(245, 34);
            this.btn_on.TabIndex = 0;
            this.btn_on.Text = "Turn on GPIO pin 3 of Arduino";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(82, 158);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(245, 34);
            this.btn_off.TabIndex = 1;
            this.btn_off.Text = "Turn off GPIO pin 3 of Arduino";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 258);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "Form1";
            this.Text = "Interfacing with Arduino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
    }
}

