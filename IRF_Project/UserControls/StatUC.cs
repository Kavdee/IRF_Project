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
            GetGoals();
        }

        private void GetGoals()
        {
            var golok = (from x in context.Jatékosok
                         where x.Gólpassz+ x.Gól>0
                         select new Focista()
                         {
                             Nev = x.Név,
                             Gol = x.Gól,
                             Golpassz=x.Gólpassz,
                         });
            chart1.DataSource = golok.ToList();
            chart1.DataBind();
            dataGridView1.DataSource = golok.ToList();
            
        }

        public class Focista
        {
            public string Nev { get; set; }
            public decimal? Gol { get; set; }
            public decimal? Golpassz { get; set; }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
