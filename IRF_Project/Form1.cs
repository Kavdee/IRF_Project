using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Project.UserControls;
using IRF_Project.Classes;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        private List<Labda> _labda = new List<Labda>();
        int kesik = 0;
        public Form1()
        {
            InitializeComponent();

            Kezdo();

        }

        private void Kezdo()
        {
            panel1.Left = 0;
            panel1.Width = 1500;
            panel1.Height = 720;
            rajzUC ruc = new rajzUC();
            ruc.Show();
            panel1.Controls.Add(ruc);
        }



        private void jatekosButton_Click(object sender, EventArgs e)
        {
            PanelClear();
            jatekosokUC juc = new jatekosokUC();
            juc.Show();
            panel1.Controls.Add(juc);
        }

        private void statisztikaButton_Click(object sender, EventArgs e)
        {
            PanelClear();
            StatUC suc = new StatUC();
            suc.Show();
            panel1.Controls.Add(suc);
        }

        private void bezarButton_Click(object sender, EventArgs e)
        {
            Startpositon();

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PanelClear();
            torloUC tuc = new torloUC();
            tuc.Show();
            panel1.Controls.Add(tuc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kesik = kesik + 1;
            if (kesik == 2)
            {
                timer1.Stop();
                PanelClear();
                Startpositon();
                panel1.Width = 1000;
                panel1.Height = 650;
                panel1.Left = torlesButton.Width + 30;
                
            }

        }
        private void Startpositon()
        {
            panel1.Visible = false;
            bezarButton.Visible = false;
            jatekosButton.Visible = true;
            statisztikaButton.Visible = true;
            torlesButton.Visible = true;
        }

        private void PanelClear()
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            bezarButton.Visible = true;
        }
    }
}
