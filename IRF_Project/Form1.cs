using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Startpositon();
        }

        private void Startpositon()
        {
            panel1.Visible = false;
            bezarButton.Visible = false;
            jatekosButton.Visible = true;
            statisztikaButton.Visible = true;
        }

        private void jatekosButton_Click(object sender, EventArgs e)
        {
            PanelClear();
            jatekosUC juc = new jatekosUC();
            juc.Show();
            panel1.Controls.Add(juc);
        }

        private void PanelClear()
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            bezarButton.Visible = true;
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
    }
}
