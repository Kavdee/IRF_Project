﻿namespace IRF_Project
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
            this.jatekosButton = new System.Windows.Forms.Button();
            this.statisztikaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bezarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jatekosButton
            // 
            this.jatekosButton.Location = new System.Drawing.Point(13, 13);
            this.jatekosButton.Name = "jatekosButton";
            this.jatekosButton.Size = new System.Drawing.Size(91, 42);
            this.jatekosButton.TabIndex = 0;
            this.jatekosButton.Text = "Játékosok";
            this.jatekosButton.UseVisualStyleBackColor = true;
            this.jatekosButton.Click += new System.EventHandler(this.jatekosButton_Click);
            // 
            // statisztikaButton
            // 
            this.statisztikaButton.Location = new System.Drawing.Point(12, 74);
            this.statisztikaButton.Name = "statisztikaButton";
            this.statisztikaButton.Size = new System.Drawing.Size(91, 42);
            this.statisztikaButton.TabIndex = 1;
            this.statisztikaButton.Text = "Statisztika";
            this.statisztikaButton.UseVisualStyleBackColor = true;
            this.statisztikaButton.Click += new System.EventHandler(this.statisztikaButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 402);
            this.panel1.TabIndex = 2;
            // 
            // bezarButton
            // 
            this.bezarButton.Location = new System.Drawing.Point(894, 420);
            this.bezarButton.Name = "bezarButton";
            this.bezarButton.Size = new System.Drawing.Size(91, 42);
            this.bezarButton.TabIndex = 3;
            this.bezarButton.Text = "Bezárás";
            this.bezarButton.UseVisualStyleBackColor = true;
            this.bezarButton.Visible = false;
            this.bezarButton.Click += new System.EventHandler(this.bezarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 476);
            this.Controls.Add(this.bezarButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statisztikaButton);
            this.Controls.Add(this.jatekosButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jatekosButton;
        private System.Windows.Forms.Button statisztikaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bezarButton;
    }
}

