
namespace Client_01
{
    partial class Form_C
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(582, 49);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(75, 23);
            this.btn_on.TabIndex = 0;
            this.btn_on.Text = "Browse";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "D:/";
            this.openFileDialog1.InitialDirectory = "D:/";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(167, 49);
            this.searchbox.Name = "searchbox";
            this.searchbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchbox.Size = new System.Drawing.Size(379, 22);
            this.searchbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image location:";
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(312, 119);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(75, 23);
            this.btn_off.TabIndex = 1;
            this.btn_off.Text = "Send";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // Form_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Name = "Form_C";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_off;
    }
}

