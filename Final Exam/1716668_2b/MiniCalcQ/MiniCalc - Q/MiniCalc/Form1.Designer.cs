﻿
namespace MiniCalc
{
    partial class MiniCalc
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
            this.num_0 = new System.Windows.Forms.Button();
            this.num_1 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_0
            // 
            this.num_0.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_0.Location = new System.Drawing.Point(231, 23);
            this.num_0.Margin = new System.Windows.Forms.Padding(4);
            this.num_0.Name = "num_0";
            this.num_0.Size = new System.Drawing.Size(48, 38);
            this.num_0.TabIndex = 0;
            this.num_0.Text = "0";
            this.num_0.UseVisualStyleBackColor = false;
            this.num_0.Click += new System.EventHandler(this.num_0_Click);
            // 
            // num_1
            // 
            this.num_1.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_1.Location = new System.Drawing.Point(296, 23);
            this.num_1.Margin = new System.Windows.Forms.Padding(4);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(48, 38);
            this.num_1.TabIndex = 1;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = false;
            this.num_1.Click += new System.EventHandler(this.num_1_Click);
            // 
            // num_2
            // 
            this.num_2.BackColor = System.Drawing.Color.LemonChiffon;
            this.num_2.Location = new System.Drawing.Point(361, 23);
            this.num_2.Margin = new System.Windows.Forms.Padding(4);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(48, 38);
            this.num_2.TabIndex = 2;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = false;
            this.num_2.Click += new System.EventHandler(this.num_2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.PowderBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(232, 90);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(48, 38);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.PowderBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(288, 90);
            this.divide.Margin = new System.Windows.Forms.Padding(4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(48, 38);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(28, 26);
            this.display.Margin = new System.Windows.Forms.Padding(4);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(177, 30);
            this.display.TabIndex = 7;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.PowderBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(344, 90);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(65, 38);
            this.clear.TabIndex = 8;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.PowderBlue;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(232, 135);
            this.equals.Margin = new System.Windows.Forms.Padding(4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(48, 38);
            this.equals.TabIndex = 9;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // MiniCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 204);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.num_0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniCalc";
            this.Load += new System.EventHandler(this.MiniCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num_0;
        private System.Windows.Forms.Button num_1;
        private System.Windows.Forms.Button num_2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equals;
    }
}

