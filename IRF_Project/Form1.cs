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
        public Form1()
        {
            InitializeComponent();
            Startpositon();
            Labdagyar Gyar = new Labdagyar();
            Addlabda(Gyar);

        }

        private void Addlabda(Labdagyar Gyar)
        {
            var labda = Gyar.createnew();
            _labda.Add(labda);
            labda.Top = 650;
            labda.Left = 750 + labda.Width / 2;
            Controls.Add(labda);
            timer1.Start();
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
            jatekosokUC juc = new jatekosokUC();
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

        private void button1_Click(object sender, EventArgs e)
        {
            PanelClear();
            torloUC tuc = new torloUC();
            tuc.Show();
            panel1.Controls.Add(tuc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _labda)
            {
                ball.MoveLabda();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }
        }
    }
}
