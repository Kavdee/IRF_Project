namespace IRF_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jatekosButton = new System.Windows.Forms.Button();
            this.statisztikaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bezarButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // jatekosButton
            // 
            this.jatekosButton.BackColor = System.Drawing.Color.Red;
            this.jatekosButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jatekosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jatekosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekosButton.ForeColor = System.Drawing.Color.White;
            this.jatekosButton.Location = new System.Drawing.Point(13, 38);
            this.jatekosButton.Name = "jatekosButton";
            this.jatekosButton.Size = new System.Drawing.Size(120, 50);
            this.jatekosButton.TabIndex = 0;
            this.jatekosButton.Text = "Játékosok";
            this.jatekosButton.UseVisualStyleBackColor = false;
            this.jatekosButton.Visible = false;
            this.jatekosButton.Click += new System.EventHandler(this.jatekosButton_Click);
            // 
            // statisztikaButton
            // 
            this.statisztikaButton.BackColor = System.Drawing.Color.Red;
            this.statisztikaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.statisztikaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisztikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisztikaButton.ForeColor = System.Drawing.Color.White;
            this.statisztikaButton.Location = new System.Drawing.Point(13, 122);
            this.statisztikaButton.Name = "statisztikaButton";
            this.statisztikaButton.Size = new System.Drawing.Size(120, 50);
            this.statisztikaButton.TabIndex = 1;
            this.statisztikaButton.Text = "Statisztika";
            this.statisztikaButton.UseVisualStyleBackColor = false;
            this.statisztikaButton.Visible = false;
            this.statisztikaButton.Click += new System.EventHandler(this.statisztikaButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(141, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 650);
            this.panel1.TabIndex = 2;
            // 
            // bezarButton
            // 
            this.bezarButton.BackColor = System.Drawing.Color.Red;
            this.bezarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bezarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezarButton.ForeColor = System.Drawing.Color.White;
            this.bezarButton.Location = new System.Drawing.Point(13, 597);
            this.bezarButton.Name = "bezarButton";
            this.bezarButton.Size = new System.Drawing.Size(120, 50);
            this.bezarButton.TabIndex = 3;
            this.bezarButton.Text = "Bezárás";
            this.bezarButton.UseVisualStyleBackColor = false;
            this.bezarButton.Visible = false;
            this.bezarButton.Click += new System.EventHandler(this.bezarButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.BackColor = System.Drawing.Color.Red;
            this.torlesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.torlesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torlesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesButton.ForeColor = System.Drawing.Color.White;
            this.torlesButton.Location = new System.Drawing.Point(12, 205);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(120, 50);
            this.torlesButton.TabIndex = 4;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = false;
            this.torlesButton.Visible = false;
            this.torlesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1482, 673);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.bezarButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statisztikaButton);
            this.Controls.Add(this.jatekosButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arsenal program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jatekosButton;
        private System.Windows.Forms.Button statisztikaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bezarButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Timer timer1;
    }
}

