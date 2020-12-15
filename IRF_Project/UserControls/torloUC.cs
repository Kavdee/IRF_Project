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

namespace IRF_Project.UserControls
{
    public partial class torloUC : UserControl
    {
        ArsenalEntities1 context = new ArsenalEntities1();
        public torloUC()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Név";
            GetNev();
            GetDGW();
            
        }

        private void GetNev()
        {
            listBox1.DataSource = (
                from x in context.Jatékosok
                where x.Név.Contains(textBox1.Text)
                select x).ToList();
        }

        private void GetDGW()
        {
            Jatékosok jatekos = (Jatékosok)listBox1.SelectedItem;
            var jatekosok =( from x in context.Jatékosok
                            where x.Mezszám == jatekos.Mezszám
                            select new Focista()
                            {
                                Nev = x.Név,
                                Gol = x.Gól,
                                Golpassz = x.Gólpassz
                            });
            dataGridView1.DataSource = jatekosok.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetNev();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDGW();
        }

        private void eltavolitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Jatékosok jatekos = (Jatékosok)listBox1.SelectedItem;
                var torles = from x in context.Jatékosok
                                 where x.Mezszám == jatekos.Mezszám
                                 select x;
                context.Jatékosok.Remove(torles.FirstOrDefault());
                context.SaveChanges();
                MessageBox.Show("A játékos kikerült az adatbázisból");
            }
            catch (Exception)
            {
                MessageBox.Show("Sikertelen");
            }
            GetDGW();
            GetNev();
        }
    }
}
