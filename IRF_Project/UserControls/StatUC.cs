using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class StatUC : UserControl
    {
        ArsenalEntities1 context = new ArsenalEntities1();
        public StatUC()
        {
            InitializeComponent();
            var golok = (from x in context.Jatékosok
                         //group x by new { x.Név } into g
                         select new Focista()
                         {
                             Nev = x.Név,
                             Ertek = x.Gól
                         });
            chart1.DataSource = golok.ToList();
            chart1.DataBind();
        }
        
        public class Focista
        {
            public string Nev { get; set; }
            public decimal? Ertek { get; set; }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
