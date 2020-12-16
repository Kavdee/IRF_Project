using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Project.Classes;
using IRF_Project.UserControls;

namespace IRF_Project.UserControls
{
    public partial class rajzUC : UserControl
    {
        private List<Labda> _labda = new List<Labda>();
        public rajzUC()
        {
            InitializeComponent();
            Labdagyar Gyar = new Labdagyar();
            Addlabda(Gyar);



        }

        private void Addlabda(Labdagyar Gyar)
        {
            var labda = Gyar.createnew();
            _labda.Add(labda);
            labda.Top =500;
            labda.Left = 600+ labda.Width / 2;
            Controls.Add(labda);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void rajzUC_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);


            myPen.Width = 5;
            g.DrawLine(myPen, 610, 400, 610, 250);
            g.DrawLine(myPen, 610, 250, 910, 250);
            g.DrawLine(myPen, 910, 400, 910, 250);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (var ball in _labda)
            {
                ball.MoveLabda();
                if (ball.Top == 260)
                {
                    timer1.Stop();

                }
            }
        }
    }
    
}
