using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Classes
{
    class Labda : Label
    {
        public Labda()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Labda_Paint;

        }

        private void Labda_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color.White), 0, 0, Width, Height);
        }
        public virtual void MoveLabda()
        {
            Top -= 1;
            
            
        }
    }
}
